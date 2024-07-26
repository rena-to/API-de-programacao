-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema gestor
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema gestor
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `gestor` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `gestor` ;

-- -----------------------------------------------------
-- Table `gestor`.`empresa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gestor`.`empresa` (
  `idEmpresa` INT NOT NULL AUTO_INCREMENT,
  `cnpj` VARCHAR(45) NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  `rua` VARCHAR(45) NOT NULL,
  `numero` VARCHAR(45) NOT NULL,
  `cep` VARCHAR(45) NOT NULL,
  `telefone` VARCHAR(20) NOT NULL,
  `email` VARCHAR(80) NOT NULL,
  `caixa` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (`idEmpresa`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `gestor`.`funcionario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gestor`.`funcionario` (
  `Empresa_idEmpresa` INT NOT NULL,
  `idFuncionario` INT NOT NULL AUTO_INCREMENT,
  `carteira` VARCHAR(7) NOT NULL,
  `cpf` VARCHAR(14) NOT NULL,
  `telefone` VARCHAR(20) NOT NULL,
  `rua` VARCHAR(100) NOT NULL,
  `cep` VARCHAR(20) NOT NULL,
  `nome` VARCHAR(100) NOT NULL,
  `usuario` VARCHAR(45) NULL DEFAULT NULL,
  `senha` VARCHAR(45) NULL DEFAULT NULL,
  `cargo` VARCHAR(45) NOT NULL,
  `admissao` DATETIME NOT NULL,
  `formacao` VARCHAR(30) NOT NULL,
  `departamento` VARCHAR(30) NOT NULL,
  `salario` DECIMAL(10,2) NOT NULL,
  `cargaHoraria` INT NOT NULL,
  `idade` INT NOT NULL,
  PRIMARY KEY (`idFuncionario`),
  CONSTRAINT `fk_Empresa_has_Funcionario`
    FOREIGN KEY (`Empresa_idEmpresa`)
    REFERENCES `gestor`.`empresa` (`idEmpresa`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `gestor`.`produto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gestor`.`produto` (
  `Empresa_idEmpresa` INT NOT NULL,
  `idProduto` INT NOT NULL AUTO_INCREMENT,
  `nomeProduto` VARCHAR(30) NOT NULL,
  `descricao` VARCHAR(50) NOT NULL,
  `preco` DECIMAL(5,2) NOT NULL,
  `quantidade` INT NOT NULL,
  `categoria` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`idProduto`),
  CONSTRAINT `fk_Empresa_has_Produto`
    FOREIGN KEY (`Empresa_idEmpresa`)
    REFERENCES `gestor`.`empresa` (`idEmpresa`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `gestor`.`gestao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `gestor`.`gestao` (
  `Funcionario_idFuncionario` INT NOT NULL,
  `Produto_idProduto` INT NOT NULL,
  `idGestao` INT NOT NULL,
  `data` DATETIME NOT NULL,
  `tipo` VARCHAR(30) NOT NULL,
  `descricao` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`Funcionario_idFuncionario`, `Produto_idProduto`, `idGestao`),
  INDEX `fk_Funcionario_has_Produto_Produto1_idx` (`Produto_idProduto` ASC) VISIBLE,
  INDEX `fk_Funcionario_has_Produto_Funcionario_idx` (`Funcionario_idFuncionario` ASC) VISIBLE,
  CONSTRAINT `fk_Funcionario_has_Produto_Funcionario`
    FOREIGN KEY (`Funcionario_idFuncionario`)
    REFERENCES `gestor`.`funcionario` (`idFuncionario`),
  CONSTRAINT `fk_Funcionario_has_Produto_Produto`
    FOREIGN KEY (`Produto_idProduto`)
    REFERENCES `gestor`.`produto` (`idProduto`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
