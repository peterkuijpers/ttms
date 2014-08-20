



-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 08/08/2014 20:07:18
-- Generated from EDMX file: C:\Users\Peter.Kuijpers\Documents\VB2010Projects\TTMS\TTMS\Database\MySqlModel.edmx
-- Target version: 2.0.0.0
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;
    DROP TABLE IF EXISTS `department`;
    DROP TABLE IF EXISTS `ncr`;
    DROP TABLE IF EXISTS `notification`;
    DROP TABLE IF EXISTS `user`;
    DROP TABLE IF EXISTS `userlevel`;
SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

CREATE TABLE `departments`(
	`id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`description` varchar (255) NOT NULL);

ALTER TABLE `departments` ADD PRIMARY KEY (id);




CREATE TABLE `ncrs`(
	`id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`raisedby_id` int NOT NULL, 
	`assignedto_id` int, 
	`delegatedto_id` int, 
	`raiseddate` datetime, 
	`status_id` int NOT NULL, 
	`cc_id` int, 
	`rcp_id` int, 
	`description` varchar (512) NOT NULL, 
	`title` varchar (255) NOT NULL);

ALTER TABLE `ncrs` ADD PRIMARY KEY (id);




CREATE TABLE `notifications`(
	`id` int NOT NULL, 
	`user_id` int NOT NULL, 
	`ncr_id` int NOT NULL, 
	`message` varchar (255) NOT NULL, 
	`timestamp` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP);

ALTER TABLE `notifications` ADD PRIMARY KEY (id);




CREATE TABLE `users`(
	`id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`firstname` varchar (45) NOT NULL, 
	`surname` varchar (45) NOT NULL, 
	`userid` varchar (10) NOT NULL, 
	`email` varchar (100), 
	`active` tinyint NOT NULL, 
	`level_id` int NOT NULL, 
	`department_id` int NOT NULL, 
	`password` varchar (10) NOT NULL, 
	`admin` tinyint NOT NULL, 
	`usercol` varchar (45));

ALTER TABLE `users` ADD PRIMARY KEY (id);




CREATE TABLE `userlevels`(
	`id` int NOT NULL, 
	`fulldescription` varchar (75), 
	`shortdescription` varchar (30));

ALTER TABLE `userlevels` ADD PRIMARY KEY (id);






-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on `level_id` in table 'users'

ALTER TABLE `users`
ADD CONSTRAINT `FK_user_userlevel`
    FOREIGN KEY (`level_id`)
    REFERENCES `userlevels`
        (`id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_user_userlevel'

CREATE INDEX `IX_FK_user_userlevel` 
    ON `users`
    (`level_id`);

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
