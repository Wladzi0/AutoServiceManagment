SELECT * FROM Person


CREATE TABLE Person
(
	Id INT NOT NULL PRIMARY KEY, 
    FirsName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(15) NOT NULL
)

INSERT INTO dbo.Person
(
    Id,
    FirsName,
    LastName,
    Email,
    Phone
)
VALUES
(   1, 
    'Adelina', 
	'Krzywczuk',
	'example@gmail.com',
    '575575676'
    ),
	(   2, 
    'Julian', 
	'Duda',
	'exampleDda@gmail.com',
    '575575676'
    );
