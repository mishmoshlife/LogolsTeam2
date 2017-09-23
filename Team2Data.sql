INSERT INTO Team2.payment_type(payment_type)
VALUES('Cash'),
	  ('Visa'),
	  ('MasterCard'),
	  ('Discover'),
	  ('AmEx'),
	  ('PayPal');

	  INSERT INTO Team2.measure(measure, measure_abbr)
VALUES ('Ounce', 'oz.'),
	   ('Cup', ''),
	   ('Teaspoon', 'Tsp'),
	   ('Tablespoon', 'Tbl');

INSERT INTO Team2.ingredient(ingredient_name, measure_id, calories, sodium, fat, carb, protein, sugars)
VALUES('Coffee', '1', '0', '0', '0', '0', '0', '0'),
	  ('Decaf Coffee', '1', '0', '0', '0', '0', '0', '0'),
	  ('Espresso', '1', '0', '0', '0', '0', '0', '0'),
	  ('Milk - Whole', '1', '18', '12.2', '1', '1.6', '1', '1.6'),
	  ('Chocolate Syrup', '1', '85', '8', '3', '21', '0', '19'),
	  ('Caramel Syrup', '1', '80', '0', '0', '20', '0', '19'),
	  ('Vanilla Syrup', '1', '80', '0', '0', '20', '0', '20'),
	  ('Pumpkin Spice Syrup', '1', '80', '0', '0', '19', '0', '18'),
	  ('Cream', '1', '77', '0', '7', '3', '0', '3'),
	  ('Sugar', '3', '16', '0', '0', '4', '0', '4'),
	  ('Whipped Cream', '1', '15', '0', '1', '1', '0', '1');

	  INSERT INTO Team2.Product(product_name, price)
	  VALUES('Coffee', '2.00'),
		    ('Decaf Coffee', '2.00'),
			('Mocha Latte', '3.50'),
			('Caramel Latte', '3.50'),
			('Hot Chocolate', '2.00'),
			('Candy Bar Latte', '3.50'),
			('Vanilla Latte', '3.50'),
			('Zebra Latte', '3.50'),
			('Pumpkin Spice Latte', '3.50');

INSERT INTO Team2.product_ingredient(product_id, ingredient_id, quantity)
VALUES('1', '12', '16'),
	  ('2', '13', '16'),
	  ('3', '14', '2'),
	  ('3', '16', '2'),
	  ('3', '15', '10'),
	  ('4', '14', '2'),
	  ('4', '17', '2'),
	  ('4', '15', '10'),
	  ('5', '18', '1'),
	  ('5', '16', '3'),
	  ('5', '15', '10'),
	  ('6', '14', '2'),
	  ('6', '17', '2'),
	  ('6', '16', '2'), 
	  ('6', '15', '10'),
	  ('7', '14', '2'),
	  ('7', '18', '2'),
	  ('7', '15', '10'),
	  ('8', '14', '2'),
	  ('8', '18', '2'),
	  ('8', '16', '2'),
	  ('8', '15', '8'),
	  ('9', '14', '2'),
	  ('9', '18', '2'),
	  ('9', '19', '2'),
	  ('9', '15', '8');

/* Get All Ingredients for a Product */
SELECT p.quantity, i.ingredient_name
FROM Team2.product_ingredient p
INNER JOIN Team2.ingredient i
ON p.ingredient_id = i.ingredient_id
WHERE p.product_id = '6';