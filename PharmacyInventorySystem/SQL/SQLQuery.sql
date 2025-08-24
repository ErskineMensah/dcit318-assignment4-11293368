USE PharmacyDB;
GO

-- Create Medicines table
CREATE TABLE Medicines (
    MedicineID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50),
    Price DECIMAL(10,2) NOT NULL,
    Quantity INT NOT NULL
);

-- Create Sales table
CREATE TABLE Sales (
    SaleID INT PRIMARY KEY IDENTITY(1,1),
    MedicineID INT FOREIGN KEY REFERENCES Medicines(MedicineID),
    QuantitySold INT NOT NULL,
    SaleDate DATETIME DEFAULT GETDATE()
);
GO

-- Create stored procedures
CREATE PROCEDURE AddMedicine
    @Name NVARCHAR(100),
    @Category NVARCHAR(50),
    @Price DECIMAL(10,2),
    @Quantity INT
AS
BEGIN
    INSERT INTO Medicines (Name, Category, Price, Quantity)
    VALUES (@Name, @Category, @Price, @Quantity);
END
GO

CREATE PROCEDURE SearchMedicineByName
    @SearchTerm NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Medicines 
    WHERE Name LIKE '%' + @SearchTerm + '%';
END
GO

CREATE PROCEDURE SearchMedicineByCategory
    @SearchTerm NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Medicines 
    WHERE Category LIKE '%' + @SearchTerm + '%';
END
GO

CREATE PROCEDURE UpdateStock
    @MedicineID INT,
    @Quantity INT
AS
BEGIN
    UPDATE Medicines SET Quantity = @Quantity 
    WHERE MedicineID = @MedicineID;
END
GO

CREATE PROCEDURE RecordSale
    @MedicineID INT,
    @QuantitySold INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        INSERT INTO Sales (MedicineID, QuantitySold) 
        VALUES (@MedicineID, @QuantitySold);
        
        UPDATE Medicines SET Quantity = Quantity - @QuantitySold 
        WHERE MedicineID = @MedicineID;
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

CREATE PROCEDURE GetAllMedicines
AS
BEGIN
    SELECT * FROM Medicines;
END
GO

-- Insert sample data
INSERT INTO Medicines (Name, Category, Price, Quantity) VALUES
('Paracetamol 500mg', 'Analgesic', 12.50, 200),
('Amoxicillin 250mg', 'Antibiotic', 25.00, 150),
('Prednisolone 5mg', 'Corticosteroid', 32.00, 110),
('Paracetamol 500mg', 'Analgesic', 10.00, 300),
('Ibuprofen 200mg', 'Anti-inflammatory', 15.00, 200),
('Ciprofloxacin 500mg', 'Antibiotic', 40.00, 120),
('Metformin 500mg', 'Antidiabetic', 20.00, 250),
('Amlodipine 5mg', 'Antihypertensive', 30.00, 180),
('Cetirizine 10mg', 'Antihistamine', 12.00, 100),
('Omeprazole 20mg', 'Antacid', 22.00, 140),
('Aspirin 100mg', 'Analgesic', 8.00, 400),
('Azithromycin 250mg', 'Antibiotic', 35.00, 90),
('Losartan 50mg', 'Antihypertensive', 28.00, 160),
('Glibenclamide 5mg', 'Antidiabetic', 18.00, 130),
('Cetirizine 10mg', 'Antihistamine', 18.75, 90);
GO