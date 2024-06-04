DROP TABLE Stock;
DROP TABLE Product;
CREATE TABLE Product (
    ProductId BIGINT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL DEFAULT 0.00,
    CreatedDate DATETIMEOFFSET DEFAULT GETDATE(),
    ModifiedDate DATETIMEOFFSET
);

CREATE TABLE Stock (
    StockId BIGINT PRIMARY KEY IDENTITY(1,1),
    ProductId BIGINT NOT NULL,
    Quantity INT NOT NULL DEFAULT 0,
    CreatedDate DATETIMEOFFSET DEFAULT GETDATE(),
    ModifiedDate DATETIMEOFFSET,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

INSERT INTO Product (Name, Price) VALUES('Product 1', 9.99)
INSERT INTO Product (Name, Price) VALUES('Product 2', 19.99)
INSERT INTO Product (Name, Price) VALUES('Product 3', 29.99)
INSERT INTO Product (Name, Price) VALUES('Product 4', 39.99)


INSERT INTO Stock (ProductID, Quantity) VALUES(1, 4)
INSERT INTO Stock (ProductID, Quantity) VALUES(2, 3)
INSERT INTO Stock (ProductID, Quantity) VALUES(3, 2)
INSERT INTO Stock (ProductID, Quantity) VALUES(4, 1)


SELECT * from Product
SELECT * from Stock