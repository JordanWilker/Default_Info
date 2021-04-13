-- USE rpg123;
-- CREATE TABLE profiles
-- (
--     id VARCHAR(255) NOT NULL,
--     email VARCHAR(255) NOT NULL,
--     name VARCHAR(255),
--     picture VARCHAR(255),
--     PRIMARY KEY (id)
-- );
-- CREATE TABLE adventurers
-- (
--     id VARCHAR(255) NOT NULL,
--     class VARCHAR(255) NOT NULL,
--     race VARCHAR(255) NOT NULL,
--     name VARCHAR(255) NOT NULL,
--     title VARCHAR(255) NOT NULL,
--     isDead TINYINT,
--     PRIMARY KEY(id)
-- )
CREATE TABLE defaultInfo
(
    id INT AUTO_INCREMENT,
    name VARCHAR(255),
    amount INT,
    PRIMARY KEY(id)
);
