-------------
--ADDRESSES--
-------------
INSERT INTO Addresses (Type, Description, StreetName, StreetNumber, PostalCode, City)
	VALUES ('0', 'Townhall Rhenen', 'Veenendaalseweg', '75','3911MG','Rhenen');

INSERT INTO Addresses (Type, Description, StreetName, StreetNumber, PostalCode, City)
	VALUES ('0', 'Townhall Veenendaal', 'Raadhuisplein', '1','3901GA','Veenendaal');

INSERT INTO Addresses (Type, Description, StreetName, StreetNumber, PostalCode, City)
	VALUES ('0', 'Library Veenendaal', 'Kees Stipplein', '73','3901TP','Veenendaal');
	
INSERT INTO Addresses (Type, Description, StreetName, StreetNumber, PostalCode, City)
	VALUES ('1', 'Rhenam Wonen', 'Binnenhof', '9','3911NP','Rhenen');

INSERT INTO Addresses (Type, Description, StreetName, StreetNumber, PostalCode, City)
	VALUES ('0', 'Rhenam Wonen corporation house', 'Cuneralaan', '26F','3911AC','Rhenen');


----------
--OWNERS--
----------
INSERT INTO Owners (CompanyName, AddressId)
	VALUES('Rhenen municipal', 1);

INSERT INTO Owners (CompanyName, AddressId)
	VALUES('Veenendaal municipal', 2);

INSERT INTO Owners (CompanyName, AddressId)
	VALUES('Rhenam Wonen', 4);


-----------------
--BUILDINGROUPS--
-----------------
INSERT INTO BuildingGroups (Name, OwnerId)
	VALUES ('Rhenen municipal buildings', '1');

INSERT INTO BuildingGroups (Name, OwnerId)
	VALUES ('Veenendaal municipal buildings', '2');

INSERT INTO BuildingGroups (Name, OwnerId)
	VALUES ('Rhenam housing corporation buildings Rhenen', '3');


-------------
--BUILDINGS--
-------------
INSERT INTO Buildings (Name, Description, BuildingGroupId, AddressId)
	VALUES ('Townhall Rhenen', 'Townhall Rhenen building description', '1', '1');

INSERT INTO Buildings (Name, Description, BuildingGroupId, AddressId)
	VALUES ('Townhall Veenendaal', 'Townhall Veenendaal building description', '2', '2');

INSERT INTO Buildings (Name, Description, BuildingGroupId, AddressId)
	VALUES ('Library Veenendaal', 'Library Veenendaal building description', '2', '3');

INSERT INTO Buildings (Name, Description, BuildingGroupId, AddressId)
	VALUES ('Rhenam Wonen corporation house', 'Rhenam Wonen corporation house - Cuneralaan 26F', '3', '5');


----------------
--ENERGYMETERS--
----------------
INSERT INTO EnergyMeters (Name, Model, Status, Type, Capacity, Unit, BuildingId)
	VALUES ('Electicity meter 1', 'Electricity meter Model X', '2', '0', '3','0','1');

INSERT INTO EnergyMeters (Name, Model, Status, Type, Capacity, Unit, BuildingId)
	VALUES ('Electicity meter 2', 'Electricity meter Model X', '2', '0', '3','0','1');

INSERT INTO EnergyMeters (Name, Model, Status, Type, Capacity, Unit, BuildingId)
	VALUES ('Water meter 1', 'Water meter Model X', '2', '3', '8','2','1');

INSERT INTO EnergyMeters (Name, Model, Status, Type, Capacity, Unit, BuildingId)
	VALUES ('Water meter 2', 'Water meter Model X', '3', '3', '8','2','1');
	
INSERT INTO EnergyMeters (Name, Model, Status, Type, Capacity, Unit, BuildingId)
	VALUES ('Gas meter 1', 'Gas meter Model X', '3', '1', '6','1','1');
		
INSERT INTO EnergyMeters (Name, Model, Status, Type, Capacity, Unit, BuildingId)
	VALUES ('Gas meter 1', 'Gas meter Model X', '0', '2', '12','0','1');