USE LibraryDB;
GO

CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(50) NOT NULL UNIQUE
);
GO

CREATE TABLE Books (
    BookID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    Publisher NVARCHAR(100),
    CategoryID INT NOT NULL,
    Quantity INT NOT NULL DEFAULT 0 CHECK (Quantity >= 0),
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
    JoinDate DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE Borrowings (
    BorrowID INT IDENTITY(1,1) PRIMARY KEY,
    BookID INT NOT NULL,
    MemberID INT NOT NULL,
    BorrowDate DATETIME DEFAULT GETDATE(),
    ReturnDate DATETIME NULL,
    Status NVARCHAR(20) NOT NULL DEFAULT 'Borrowed',

    CONSTRAINT FK_Borrowings_Books
        FOREIGN KEY (BookID) REFERENCES Books(BookID),

    CONSTRAINT FK_Borrowings_Members
        FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);
GO

INSERT INTO Categories (CategoryName) VALUES
('Science'),
('Programming'),
('Math');
GO

INSERT INTO Books (Title, Author, Publisher, CategoryID, Quantity, Price) VALUES
('Science Basics', 'Zewail', 'Publisher1', 1, 5, 50.00),
('Python Fundamentals', 'Elzero', 'Publisher2', 2, 3, 70.00),
('Math Essentials', 'Zewail', 'Publisher3', 3, 10, 40.00);
GO

INSERT INTO Members (FullName, Email, Phone) VALUES
('Amina', 'amina@example.com', '01011112222'),
('Reem', 'reem@example.com', '01033334444');
GO

CREATE PROCEDURE AddBorrowing
    @BookID INT,
    @MemberID INT,
    @ExpectedReturnDate DATETIME
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    IF NOT EXISTS (SELECT 1 FROM Books WHERE BookID = @BookID)
    BEGIN
        ROLLBACK;
        RETURN;
    END

    IF (SELECT Quantity FROM Books WHERE BookID = @BookID) <= 0
    BEGIN
        ROLLBACK;
        RETURN;
    END

    INSERT INTO Borrowings (BookID, MemberID, ReturnDate, Status)
    VALUES (@BookID, @MemberID, @ExpectedReturnDate, 'Borrowed');

    UPDATE Books
    SET Quantity = Quantity - 1
    WHERE BookID = @BookID;

    COMMIT;
END;
GO

CREATE PROCEDURE ReturnBook
    @BorrowID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    DECLARE @BookID INT;

    SELECT @BookID = BookID
    FROM Borrowings
    WHERE BorrowID = @BorrowID
      AND Status = 'Borrowed';

    IF @BookID IS NULL
    BEGIN
        ROLLBACK;
        RETURN;
    END

    UPDATE Borrowings
    SET Status = 'Returned',
        ReturnDate = GETDATE()
    WHERE BorrowID = @BorrowID;

    UPDATE Books
    SET Quantity = Quantity + 1
    WHERE BookID = @BookID;

    COMMIT;
END;
GO