CREATE TABLE Team2.[product] (
	product_id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	product_name VARCHAR(80) NULL,
	[description] TEXT NULL,
	imagefile VARCHAR(80) NULL,
	price DECIMAL(10,2)
);

CREATE TABLE Team2.ingredient (
	ingredient_id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ingredient_name VARCHAR(80),
	measure_id INT NULL,
	calories DECIMAL(8,2),
	sodium DECIMAL(8,2),
	fat DECIMAL(8,2),
	carb DECIMAL(8,2),
	protein DECIMAL(8,2),
	sugars DECIMAL(8,2)

);

CREATE TABLE Team2.product_ingredient(
	product_ingredient_id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	product_id INT NOT NULL,
	ingredient_id INT NOT NULL,
	quantity DECIMAL(8,2) NULL,
	measure_id INT NULL
);

CREATE TABLE Team2.measure (
	measure_id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	measure VARCHAR(80) NOT NULL,
	measure_abbr VARCHAR(20) NULL
);

CREATE TABLE Team2.[user] (
	[user_id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	username VARCHAR(40) NOT NULL,
	[password] VARCHAR(40) NOT NULL,
	first_name VARCHAR(30) NULL,
	last_name VARCHAR(30) NULL,
	email VARCHAR(100) NULL,
	phone VARCHAR(20),
	date_created DATE NULL
);

CREATE TABLE Team2.user_favorite (
	[user_id] INT NOT NULL,
	product_id INT NOT NULL,
	PRIMARY KEY([user_id], product_id)
);

CREATE TABLE Team2.[order] (
	order_id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	order_date DATETIME2 NULL,
	[user_id] INT NOT NULL,
	payment_type_id INT NULL,
	amount_paid DECIMAL(10,2) NULL,
	order_code VARCHAR(80) NULL
);

CREATE TABLE Team2.order_item(
	order_item_id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	order_id INT NOT NULL,
	product_id INT NULL,
	quantity INT NULL,
	item_price_total DECIMAL(10,2) NULL
);

CREATE TABLE Team2.payment_type (
	payment_type_id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	payment_type VARCHAR(40)
);
