ALTER TABLE Members
ADD 
    Address NVARCHAR(200),
    IsActive BIT DEFAULT 1;
