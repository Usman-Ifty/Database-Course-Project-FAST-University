CREATE TABLE admin (
    AID INT PRIMARY KEY AUTO_INCREMENT,
    AdminName VARCHAR(255) NOT NULL,
    AcontactNo VARCHAR(15),
    Aemail VARCHAR(255)
);

CREATE TABLE employees (
    EID INT PRIMARY KEY AUTO_INCREMENT,
    EName VARCHAR(255) NOT NULL,
    EcontactNo VARCHAR(15),
    Eemail VARCHAR(255)
);

CREATE TABLE patient (
    PID INT PRIMARY KEY AUTO_INCREMENT,
    PName VARCHAR(255) NOT NULL,
    PcontactNo VARCHAR(15),
    Pemail VARCHAR(255)
);

INSERT INTO admin (AdminName, AcontactNo, Aemail) 
VALUES ('John Doe', '1234567890', 'johndoe@example.com'),
('Jane Smith', '9876543210', 'janesmith@example.com'),
('Michael Johnson', '5555555555', 'michaeljohnson@example.com'),
('Emily Williams', '1112223333', 'emilywilliams@example.com'),
('David Brown', '9998887777', 'davidbrown@example.com');

INSERT INTO employees (EName, EcontactNo, Eemail) VALUES
('Sarah Lee', '3334445555', 'sarahlee@example.com'),
('Robert Davis', '7778889999', 'robertdavis@example.com'),
('Jennifer Wilson', '1231231234', 'jenniferwilson@example.com'),
('Daniel Martinez', '5554443333', 'danielmartinez@example.com'),
('Jessica Anderson', '9876543210', 'jessicaanderson@example.com');

INSERT INTO patient (PName, PcontactNo, Pemail) VALUES
('Mark Thompson', '1112223333', 'markthompson@example.com'),
('Lisa Taylor', '8889990000', 'lisataylor@example.com'),
('Christopher Clark', '4445556666', 'christopherclark@example.com'),
('Mary Harris', '6667778888', 'maryharris@example.com'),
('Matthew Moore', '2223334444', 'matthewmoore@example.com');


