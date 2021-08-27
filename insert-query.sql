
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