# Gestione_Negozio_Cs-Wpf-Ef
```sql

CREATE TABLE Categoria (
    categoriaID INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(100) UNIQUE NOT NULL
); 

CREATE TABLE Prodotto (
    prodottoID INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(255) UNIQUE NOT NULL,
    descrizione TEXT,
	categoriaRif INT NOT NULL,
	FOREIGN KEY (categoriaRif) REFERENCES Categoria(categoriaID) ON DELETE CASCADE
);
 
CREATE TABLE Variazione (
    variazioneID INT PRIMARY KEY IDENTITY(1,1),
	codice VARCHAR(150) UNIQUE NOT NULL,
    prodottoRif INT NOT NULL,
    colore VARCHAR(50) NOT NULL,
    taglia VARCHAR(10) NOT NULL,
    quantita INT NOT NULL CHECK(quantita >=0),
    prezzo DECIMAL(10, 2) NOT NULL CHECK (prezzo>=0),
    prezzoOfferta DECIMAL(10, 2),
    dataInizioOfferta DATE,
    dataFineOfferta DATE,
	linkImmagine VARCHAR(255)
    FOREIGN KEY (prodottoRif) REFERENCES Prodotto(prodottoId) ON DELETE CASCADE
);
 

CREATE TABLE Utente (
    utenteID INT PRIMARY KEY IDENTITY(1,1),
    nominativo VARCHAR(100) NOT NULL,
    email VARCHAR(255) UNIQUE,
    indirizzo TEXT
);
 
CREATE TABLE Ordine (
    ordineID INT PRIMARY KEY IDENTITY(1,1),
    dataOrdine DATE DEFAULT CURRENT_TIMESTAMP,
	utenteRif INT NOT NULL,
    statoOrdine VARCHAR(50),
    FOREIGN KEY (utenteRif) REFERENCES Utente(utenteID) ON DELETE CASCADE,

);

 CREATE TABLE OrdineVariazione (
    ordineVariazione INT PRIMARY KEY IDENTITY(1,1),
	quantita INT NOT NULL,
	variazioneRif INT NOT NULL,
	ordineRif INT NOT NULL,
	FOREIGN KEY (ordineRif) REFERENCES Ordine(ordineID)ON DELETE CASCADE,
	FOREIGN KEY (variazioneRif) REFERENCES Variazione(variazioneID)ON DELETE CASCADE

);

-- Inserimento di dati nella tabella Categoria
INSERT INTO Categoria (nome) VALUES ('Maglie');
INSERT INTO Categoria (nome) VALUES ('Pantaloni');
INSERT INTO Categoria (nome) VALUES ('Giacche');

-- Inserimento di dati nella tabella Prodotto
INSERT INTO Prodotto (nome, descrizione, categoriaRif) VALUES ('Maglia a maniche lunghe', 'Maglia morbida e confortevole', 1);
INSERT INTO Prodotto (nome, descrizione, categoriaRif) VALUES ('Pantaloni jeans', 'Pantaloni jeans classici', 2);
INSERT INTO Prodotto (nome, descrizione, categoriaRif) VALUES ('Giacca invernale', 'Giacca calda e resistente', 3);

-- Inserimento di dati nella tabella Variazione
INSERT INTO Variazione (codice, prodottoRif, colore, taglia, quantita, prezzo, prezzoOfferta, dataInizioOfferta, dataFineOfferta, linkImmagine) 
VALUES ('MAGLIA001', 1, 'Blu', 'M', 20, 29.99, NULL, NULL, NULL, 'https://example.com/maglia-blu.jpg');

INSERT INTO Variazione (codice, prodottoRif, colore, taglia, quantita, prezzo, prezzoOfferta, dataInizioOfferta, dataFineOfferta, linkImmagine) 
VALUES ('JEANS001', 2, 'Nero', 'L', 15, 39.99, 29.99, '2024-03-01', '2024-03-15', 'https://example.com/jeans-nero.jpg');

-- Inserimento di dati nella tabella Utente
INSERT INTO Utente (nominativo, email, indirizzo) VALUES ('Mario Rossi', 'mario@example.com', 'Via Roma 123, Milano');
INSERT INTO Utente (nominativo, email, indirizzo) VALUES ('Giulia Bianchi', 'giulia@example.com', 'Corso Italia 45, Roma');

-- Inserimento di dati nella tabella OrdineVariazione
INSERT INTO OrdineVariazione (quantita, variazioneRif, ordineRif) VALUES (2, 1, 1);
INSERT INTO OrdineVariazione (quantita, variazioneRif, ordineRif) VALUES (1, 2, 2);


select * from Categoria
WHERE categoriaID=2;



```