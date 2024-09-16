CREATE TABLE Autor (  

  id INT NOT NULL IDENTITY(1,1),   

  Nome VARCHAR(50) NOT NULL,  

  PRIMARY KEY(id)  

);  

  

CREATE TABLE Configuracao (   

  CodDiaEmprestimo INT NOT NULL IDENTITY(1,1),   

  ValorAtraso FLOAT NOT NULL,  

  PRIMARY KEY(CodDiaEmprestimo)  

);  

  

CREATE TABLE Editora (  

  id INT NOT NULL IDENTITY(1,1),   

  Nome VARCHAR(50) NOT NULL,  

  PRIMARY KEY(id)  

);  

  

CREATE TABLE Genero (  

  id INT NOT NULL IDENTITY(1,1),   

  Nome VARCHAR(50) NOT NULL,  

  PRIMARY KEY(id)  

);  

  

CREATE TABLE Idioma (  

  id INT NOT NULL IDENTITY(1,1),   

  Nome VARCHAR(50) NOT NULL,  

  PRIMARY KEY(id)  

);  

  

CREATE TABLE Pessoa (  

  id INT NOT NULL IDENTITY(1,1),   

  Nome VARCHAR(50) NOT NULL,  

  PRIMARY KEY(id)  

);  

  

CREATE TABLE Emprestimo (  

  id INT NOT NULL IDENTITY(1,1),   

  idPessoa INT NOT NULL,  

  DataSaida DATE NOT NULL,  

  DataPrevistaEntrega DATE NOT NULL,  

  PRIMARY KEY(id), 

  FOREIGN KEY (idPessoa) REFERENCES Pessoa(id)   

);  

  

CREATE TABLE Livro (  

  id INT NOT NULL IDENTITY(1,1),   

  idAutor INT NOT NULL,  

  idIdioma INT NOT NULL,  

  idEditora INT NOT NULL,  

  idGenero INT NOT NULL,  

  ISBN VARCHAR(20) NOT NULL,  

  Nome VARCHAR(50) NOT NULL,  

  Descricao VARCHAR(255) NULL,  

  Edicao INT NOT NULL,  

  QtdPaginas INT NOT NULL,  

  PRIMARY KEY(id),  

  FOREIGN KEY (idGenero) REFERENCES Genero(id),    

  FOREIGN KEY (idEditora) REFERENCES Editora(id),  

  FOREIGN KEY (idIdioma) REFERENCES Idioma(id),    

  FOREIGN KEY (idAutor) REFERENCES Autor(id)       

);  

  

CREATE TABLE LivroEmprestado (  

  idEmprestimo INT NOT NULL,  

  idLivro INT NOT NULL,  

  DataEntrega DATE NULL,  

  DiasAtraso INT NULL,  

  ValorMulta FLOAT NULL,  

  ValorPago FLOAT NULL,  

  PRIMARY KEY(idEmprestimo, idLivro),  

  FOREIGN KEY (idEmprestimo) REFERENCES Emprestimo(id),   

  FOREIGN KEY (idLivro) REFERENCES Livro(id)              

); 