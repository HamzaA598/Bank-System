create database bankSystem;

CREATE TABLE Bank
(
  code VARCHAR(255) NOT NULL,
  Name VARCHAR(255) NOT NULL,
  Address VARCHAR(255) NOT NULL,
  PRIMARY KEY (code)
);

CREATE TABLE Branch
(
  Branch# int NOT NULL identity(1, 1),
  Address VARCHAR(255) NOT NULL,
  code VARCHAR(255) NOT NULL,
  PRIMARY KEY (Branch#),
  FOREIGN KEY (code) REFERENCES Bank(code)
);

CREATE TABLE UserAccount
(
  Username VARCHAR(255) NOT NULL,
  Password VARCHAR(255) NOT NULL,
  Type VARCHAR(255) NOT NULL,
  PRIMARY KEY (Username)
);

CREATE TABLE Employee
(
  ID INT NOT NULL identity(1, 1),
  Name VARCHAR(255) NOT NULL,
  Branch# int NOT NULL,
  Username VARCHAR(255) NOT NULL,

  PRIMARY KEY (ID),
  FOREIGN KEY (Branch#) REFERENCES Branch(Branch#),
  FOREIGN KEY (Username) REFERENCES UserAccount(Username)
);

CREATE TABLE Customer
(
  SSN VARCHAR(255) NOT NULL,
  Address VARCHAR(255) NOT NULL,
  Phone VARCHAR(255) NOT NULL,
  Name VARCHAR(255) NOT NULL,
  Branch# int,
  Username VARCHAR(255) NOT NULL,
  empID INT,

  PRIMARY KEY (SSN),
  FOREIGN KEY (Branch#) REFERENCES Branch(Branch#),
  FOREIGN KEY (Username) REFERENCES UserAccount(Username),
  FOREIGN KEY (empID) REFERENCES Employee(ID)
);

CREATE TABLE Loan
(
  Loan_Amount INT NOT NULL,
  Loan# int NOT NULL identity(1, 1),
  Loan_Type VARCHAR(255) NOT NULL,
  Branch# int NOT NULL,
  SSN VARCHAR(255) NOT NULL,
  empID INT NOT NULL,
  status varchar(255) not null default 'pending',

  PRIMARY KEY (Loan#),
  FOREIGN KEY (Branch#) REFERENCES Branch(Branch#),
  FOREIGN KEY (SSN) REFERENCES Customer(SSN),
  FOREIGN KEY (empID) REFERENCES Employee(ID)
);

CREATE TABLE Account
(
  Account# int NOT NULL identity(1, 1),
  Balance INT NOT NULL,
  Type VARCHAR(255) NOT NULL,
  SSN VARCHAR(255) NOT NULL,

  PRIMARY KEY (Account#),
  FOREIGN KEY (SSN) REFERENCES Customer(SSN)
);

CREATE TABLE Deals_With
(
  SSN VARCHAR(255) NOT NULL,
  ID INT NOT NULL,
  PRIMARY KEY (SSN, ID),
  FOREIGN KEY (SSN) REFERENCES Customer(SSN),
  FOREIGN KEY (ID) REFERENCES Employee(ID)
);