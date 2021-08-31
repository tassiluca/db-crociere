
insert into PORTI(CodPorto, Nazionalità, Città, PrezzoAttracco)
values('GEN', 'ITA', 'Genova', 2000),
('MARS', 'FRA', 'Marsiglia', 6000),
('BAR', 'SPA', 'Barcellona', 6500),
('SIR', 'ITA', 'Siracusa', 1300),
('TAR', 'ITA', 'Taranto', 500),
('CIVA', 'ITA', 'Civitavecchia', 3500);

insert into TRATTE(CodPortoPartenza, CodPortoArrivo)
values('BAR', 'GEN'),
('GEN', 'BAR'),
('BAR', 'MARS'),
('MARS', 'BAR'),
('GEN', 'MARS'),
('MARS', 'GEN'),
('MARS', 'SIR'),
('SIR', 'TAR'),
('TAR', 'CIVA'),
('CIVA', 'GEN');

INSERT INTO SEQUENZE_TRATTE(CodPercorso, CodTratta, Ordine)
VALUES('MED01', 5, 1),
('MED01', 12, 2),
('MED01', 13, 3),
('MED01', 14, 4),
('MED01', 15, 5);

INSERT INTO NAVIGAZIONI(NomeNave, DataInizio, DataFine, NumeroEsecuzioni, CodPercorso)
VALUES('Bellissima', '17-07-2021', '23-08-2021', 25, 'MED01');

INSERT INTO PAGAMENTI(DataPagamento, Importo)
VALUES('28-08-2021', 1500),
VALUES('26-10-2021', 2500);

INSERT INTO PRENOTAZIONI(CodTransazione, DataEffettuazione, DataOraImbarco, DataOraSbarco, Trattamento, NumeroPasseggeri, CodNavigazione, CodPorto)
VALUES(1, '28-08-2021', '30-08-2021 18:00', '15-09-2021 08:00', 'All-Inclusive', 5, 8, 'BAR'),
VALUES(4, '26-10-2021', '29-11-2021 18:00', '15-12-2021 08:00', 'All-Inclusive', 5, 8, 'BAR');
