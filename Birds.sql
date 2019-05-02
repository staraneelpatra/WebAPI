CREATE TABLE [dbo].[Birds](
    [ID] [int] NOT NULL,
    [BirdName] [varchar](50) NULL,
    [TypeOfBird] [varchar](50) NULL,
    [ScientificName] [varchar](50) NULL,
    CONSTRAINT [PK_Birds] PRIMARY KEY CLUSTERED 
    ([ID] ASC)
) ON [PRIMARY]
        
GO

INSERT INTO dbo.Birds (ID, BirdName, TypeOfBird, ScientificName)
VALUES 
    (1,	'Eurasian Collared-Dove', 'Dove', 'Streptopelia'),
    (2,	'Bald Eagle	Hawk', 'Haliaeetus', 'Leucocephalus'),
    (3,	'Coopers Hawk',	'Hawk',	'Accipiter Cooperii'),
    (4,	'Bells Sparrow', 'Sparrow', 'Artemisiospiza Belli'),
    (5,	'Mourning Dove', 'Dove', 'Zenaida Macroura'),
    (6,	'Rock Pigeon', 'Dove', 'Columba Livia'),
    (7,	'Aberts Towhee', 'Sparrow', 'Melozone Aberti'),
    (8,	'Brewers Sparrow', 'Sparrow', 'Spizella Breweri'),
    (9,	'Canyon Towhee', 'Sparrow', 'Melozone Fusca'),
    (10, 'Black Vulture', 'Hawk', 'Coragyps Atratus'),
    (11, 'Gila Woodpecker', 'Woodpecker', 'Melanerpes Uropygialis'),
    (12, 'Gilded Flicker', 'Woodpecker', 'Colaptes Chrysoides'),
    (13, 'Cassins Sparrow', 'Sparrow', 'Peucaea Cassinii'),
    (14, 'American Kestrel', 'Hawk', 'Falco Sparverius'),
    (15, 'Hairy Woodpecker', 'Woodpecker', 'Picoides villosus'),
    (16, 'Lewis Woodpecker', 'Woodpecker', 'Melanerpes Lewis'),
    (17, 'Snail Kite', 'Hawk', 'Rostrhamus Sociabilis'),
    (18, 'White-tailed Hawk', 'Hawk', 'Geranoaetus Albicaudatus')