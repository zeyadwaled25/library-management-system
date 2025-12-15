USE LibraryDB;
GO

CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Books (
    BookID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    Publisher NVARCHAR(100),
    CategoryID INT,
    Quantity INT DEFAULT 0,
    Price DECIMAL(10,2),
    CONSTRAINT FK_Books_Categories
        FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);
GO

CREATE TABLE Members (
    MemberID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE,
    Phone NVARCHAR(20),
    JoinDate DATE DEFAULT GETDATE()
);
GO

CREATE TABLE Borrowings (
    BorrowID INT IDENTITY(1,1) PRIMARY KEY,
    BookID INT NOT NULL,
    MemberID INT NOT NULL,
    BorrowDate DATE DEFAULT GETDATE(),
    ReturnDate DATE,
    Status NVARCHAR(20) DEFAULT 'Borrowed',

    CONSTRAINT FK_Borrowings_Books
        FOREIGN KEY (BookID) REFERENCES Books(BookID),

    CONSTRAINT FK_Borrowings_Members
        FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);
GO


INSERT INTO Categories (CategoryName) VALUES
('Science'),
('programming'),
('math');
GO

INSERT INTO Books (Title, Author, Publisher, CategoryID, Quantity, Price) VALUES
('science', 'Zewail', 'publisher1', 1, 5, 50.00),
('python', 'elzero', 'publisher2', 3, 3, 70.00),
('math0', 'Zewail', 'publisher3', 2, 10, 40.00);
GO

INSERT INTO Members (FullName, Email, Phone) VALUES
('Amina', 'amina@example.com', '01011112222'),
('Reem', 'reem@example.com', '01033334444');
GO

GO
CREATE PROCEDURE AddBorrowing
    @BookID INT,
    @MemberID INT,
    @ReturnDate DATE
AS
BEGIN
    IF (SELECT Quantity FROM Books WHERE BookID = @BookID) > 0
    BEGIN
        INSERT INTO Borrowings (BookID, MemberID, ReturnDate, Status)
        VALUES (@BookID, @MemberID, @ReturnDate, 'Borrowed');

        UPDATE Books
        SET Quantity = Quantity - 1
        WHERE BookID = @BookID;
    END
END;
GO

GO
CREATE PROCEDURE ReturnBook
    @BorrowID INT
AS
BEGIN
    DECLARE @BookID INT;

    SELECT @BookID = BookID
    FROM Borrowings
    WHERE BorrowID = @BorrowID;

    UPDATE Borrowings
    SET Status = 'Returned',
        ReturnDate = GETDATE()
    WHERE BorrowID = @BorrowID;

    UPDATE Books
    SET Quantity = Quantity + 1
    WHERE BookID = @BookID;
END;
GO
