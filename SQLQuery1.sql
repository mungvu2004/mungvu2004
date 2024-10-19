CREATE DATABASE WEB_TMDT;
CREATE TABLE TShirt (
    Id INT PRIMARY KEY IDENTITY(1,1),         -- ID tự động tăng
    Name NVARCHAR(100) NOT NULL,              -- Tên sản phẩm
    MainImg NVARCHAR(255),                    -- Hình ảnh chính
    Discount DECIMAL(5, 2),                   -- Giảm giá (theo phần trăm)
    OriginalPrice DECIMAL(18, 2) NOT NULL,    -- Giá gốc (giá thật)
    SecondaryImg NVARCHAR(255),               -- Hình ảnh phụ
    DiscountedPrice AS (OriginalPrice - (OriginalPrice * Discount / 100)) -- Giá sau khi giảm
);
INSERT INTO TShirt (Name, MainImg, Discount, OriginalPrice, SecondaryImg)
VALUES 
('Basic White T-Shirt', 'white_tshirt.jpg', 10.00, 200000, 'white_tshirt_side.jpg'),
('Black Graphic Tee', 'black_graphic_tee.jpg', 15.00, 300000, 'black_graphic_tee_side.jpg'),
('Red Sports T-Shirt', 'red_sports_tshirt.jpg', 5.00, 250000, 'red_sports_tshirt_back.jpg'),
('Blue Casual T-Shirt', 'blue_casual_tshirt.jpg', 20.00, 350000, 'blue_casual_tshirt_front.jpg'),
('Green V-Neck T-Shirt', 'green_vneck_tshirt.jpg', 12.50, 280000, 'green_vneck_tshirt_back.jpg');

SELECT * FROM TShirt
GO