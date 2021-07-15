-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 11.0.1              
-- * Generator date: Dec  4 2018              
-- * Generation date: Wed Jul 14 21:24:12 2021 
-- * LUN file: C:\Users\lucat\OneDrive - Alma Mater Studiorum Universit‡ di Bologna\Uni\basi-di-dati\db-crociere\er\DB-CROCIERE.lun 
-- * Schema: completo-ristrutturato-manina/1 
-- ********************************************* 


-- Database Section
-- ________________ 

create database dbotest;
use dbotest;

-- DBSpace Section
-- _______________


-- Tables Section
-- _____________ 

create table ANNULLAMENTI (
     CodicePrenotazione numeric(5) not null,
     DataRichiesta date not null,
     CodRimborso numeric(2) not null
	 constraint FK_Prenotazioni_ID primary key (CodicePrenotazione));

create table ATTIVIT¿ (
     CodAttivit‡ numeric(5) identity(1,1) not null primary key,
     Nome varchar(20) not null,
     Descrizione varchar(150) not null);

create table BADGE (
     CodBadge numeric(10) identity(1,1) not null primary key,
     CartaCredito char(16) not null,
     NomeNave varchar(30) not null,
     NumeroPonte numeric(2) not null,
     CodCabina numeric(4) not null);

create table CABINE (
     NomeNave varchar(30) not null,
     NumeroPonte numeric(2) not null,
     CodCabina numeric(4) not null,
     Capienza numeric(1) not null,
     Posizione varchar(10) not null,
     Tipologia varchar(7) not null,
     constraint PK_Cabine primary key (NomeNave, NumeroPonte, CodCabina));

create table INTRATTENIMENTI (
     DataInizio date not null,
     OrarioInizio time not null,
     CodAttivit‡ numeric(5) not null,
     CodSala char(3) not null,
     CodNavigazione numeric(3) not null,
     constraint PK_Intrattenimenti primary key (CodNavigazione, CodAttivit‡, DataInizio, OrarioInizio),
     constraint ID_Intrattenimenti unique (CodNavigazione, CodAttivit‡, CodSala, DataInizio),
     constraint ID_Intrattenimenti2 unique (CodNavigazione, CodSala, DataInizio, OrarioInizio));

create table NAVI (
     Nome varchar(30) not null primary key,
     CodNave char(5) not null unique,
     CodicePercorso char(5) not null,
     Larghezza numeric(3) not null,
     Lunghezza numeric(3) not null,
     Peso numeric(6) not null,
     Altezza numeric(3) not null,
     NumeroCabine numeric(4) not null,
	 constraint FK_Percorsi_ID unique (CodicePercorso));

create table NAVIGAZIONI (
     CodNavigazione numeric(3) identity(1,1) not null primary key,
     DataInizio date not null,
     NomeNave varchar(30) not null,
     DataFine date not null,
     NumeroEsecuzioni numeric(2) not null,
     CodicePercorso char(5) not null,
     constraint ID_Navigazioni unique (NomeNave, DataInizio));

create table PAGAMENTI (
     CodTransazione numeric(5) identity(1,1) not null primary key,
     DataPagamento date not null,
     Importo numeric(4) not null,
     NumeroRate numeric(2),
     Anticipo numeric(4));

create table PASSEGGERI (
     CodiceFiscale char(16) not null primary key,
     CodBadge numeric(10) not null,
     Nome varchar(30) not null,
     Cognome varchar(40) not null,
     Nazionalit‡ char(3) not null,
     Passaporto char(9) not null,
     constraint FK_Badge_ID unique (CodBadge));

create table PERCORSI (
     CodicePercorso char(5) not null primary key,
     GiorniDurata numeric(2) not null);

create table PERSONALE (
     CodiceFiscale char(16) not null primary key,
     Nome varchar(30) not null,
     Cognome varchar(40) not null,
     Nazionalit‡ char(3) not null,
     Passaporto char(9) not null,
     Recapito numeric(14) not null,
     Anzianit‡Servizio numeric(2),
     Grado varchar(20),
     CodRuolo char(5) not null);

create table PONTI (
     NomeNave varchar(30) not null,
     Numero numeric(2) not null,
     constraint PK_Ponti primary key (NomeNave, Numero));

create table PORTI (
     CodPorto char(4) not null primary key,
     Nazionalit‡ char(3) not null,
     Citt‡ varchar(30) not null,
     PrezzoAttracco numeric(4) not null);

create table PRENOTAZIONI (
     CodicePrenotazione numeric(5) identity(1,1) not null primary key,
     DataImbarco datetime not null,
     DataSbarco datetime not null,
     CodTransazione numeric(5) not null,
     NomeNave varchar(30) not null,
     NumeroPonte numeric(2) not null,
     CodCabina numeric(4) not null,
     CodiceFiscale char(16) not null,
     Trattamento varchar(13) not null,
     CodTariffario numeric(3) not null,
     CodNavigazione numeric(3) not null,
     CodPortoPartenza char(4) not null,
     constraint ID_Prenotazioni unique (CodiceFiscale, DataImbarco, DataSbarco),
     constraint ID_Prenotazioni2 unique (NomeNave, NumeroPonte, CodCabina, DataImbarco, DataSbarco),
     constraint FK_Pagamenti unique (CodTransazione));

create table PRENOTAZIONI_PASSEGGERI (
     CodiceFiscale char(16) not null,
     CodicePrenotazione numeric(5) not null,
     constraint PK_PrenotazioniPasseggeri primary key (CodiceFiscale, CodicePrenotazione));

create table RATE (
     DataPagamento date not null primary key,
     Importo numeric(4) not null,
     CodTransazione numeric(5) not null);

create table RESPONSABILIT¿ (
     CodRuolo char(5) not null,
     CodiceFiscale char(16) not null,
     InizioData date not null,
     InizioOra date not null,
     constraint PK_Responsabilit‡ primary key (CodRuolo, CodiceFiscale, InizioData, InizioOra));

create table RIMBORSI (
     CodRimborso numeric(2) identity(1,1) not null primary key,
     PreavvisoDal char(1) not null,
     PreavvisoAl char(1) not null,
     PercentualeRimborso numeric(3) not null,
     constraint ID_Rimborsi unique (PreavvisoDal, PreavvisoAl));

create table RUOLI (
     CodRuolo char(5) not null primary key,
     Descrizione varchar(200) not null,
     Nome varchar(30) not null,
     StipendioAnnuo numeric(6) not null);

create table SALE (
     CodSala char(3) not null primary key,
     Capienza numeric(4) not null,
     NomeNave varchar(30) not null,
     NumeroPonte numeric(2) not null);

create table SCIALUPPE (
     CodScialuppa numeric(2) identity(1,1) not null primary key,
     DataRevisione date not null,
     Capienza numeric(3) not null,
     NomeNave varchar(30) not null);

create table SEQUENZE (
     CodTratta numeric(3) not null,
     CodicePercorso char(5) not null,
     Ordine numeric(2) not null,
     constraint PK_Sequenze primary key (CodTratta, CodicePercorso));

create table SERVIZI_PERSONALE (
     CodNavigazione numeric(3) not null,
     CodiceFiscale char(16) not null,
     constraint PK_Servizi primary key (CodNavigazione, CodiceFiscale));

create table SPESE_EXTRA (
     CodiceSpesa numeric(5) identity(1,1) not null primary key,-- Sequence attribute not implemented -- not null,
     DataFattura date not null,
     Importo numeric(3) not null,
     Descrizione varchar(100) not null,
     CodBadge numeric(10) not null,
     CodicePrenotazione numeric(5) not null);

create table TARIFFARI (
     CodTariffario numeric(3) identity(1,1) not null primary key,
     TipologiaCabina varchar(7) not null,
     NomeNave varchar(30) not null,
     DataInizio date not null,
     DataFine date not null,
     Prezzo numeric(4) not null,
     constraint ID_Tariffari unique (TipologiaCabina, NomeNave, DataInizio, DataFine));

create table TIPOLOGIE (
     Nome varchar(7) not null primary key,
     Prezzo numeric(4) not null,
     Descrizione varchar(100) not null);

create table TRATTE (
     CodTratta numeric(3) identity(1,1) not null primary key,
     CodPortoArrivo char(4) not null,
     CodPortoPartenza char(4) not null,
     constraint ID_Tratte unique (CodPortoArrivo, CodPortoPartenza));

create table TRATTE_IN_NAVIGAZIONI (
     CodTrattaNavigazione numeric(5) identity(1,1) not null primary key,
     PartenzaData date not null,
     PartenzaOra date not null,
     CodTratta numeric(3) not null,
     CodNavigazione numeric(3) not null,
     ArrivoData date not null,
     ArrivoOra date not null,
     constraint ID_TratteInNavigazioni unique (CodTratta, PartenzaData),
     constraint ID_TratteInNavigazioni2 unique (CodNavigazione, PartenzaData, PartenzaOra));

create table TURNI_LAVORATIVI (
     CodiceFiscale char(16) not null,
     InizioData date not null,
     InizioOra date not null,
     FineData date not null,
     FineOra date not null,
     constraint PK_TurnoLavorativi primary key (CodiceFiscale, InizioData, InizioOra));

-- Functions 
-- ___________________
GO
CREATE FUNCTION getBadgeFromPasseggeri(@badge numeric(10))
RETURNS numeric(10)
AS
BEGIN
RETURN (select CodBadge from PASSEGGERI where PASSEGGERI.CodBadge = @badge)
END;
GO

-- Constraints Section
-- ___________________ 

alter table ANNULLAMENTI add constraint FK_Prenotazioni
     foreign key (CodicePrenotazione)
     references PRENOTAZIONI;

alter table ANNULLAMENTI add constraint FK_Rimborsi
     foreign key (CodRimborso)
     references RIMBORSI;

alter table BADGE add constraint ID_Badge_CHK
	 check(getBadgeFromPasseggeri(CodBadge) > 0);

alter table BADGE add constraint FK_Cabine
     foreign key (NomeNave, NumeroPonte, CodCabina)
     references CABINE;

--alter table CABINE add constraint ID_Cabine_CHK
--     check(exists(select * from BADGE
--                  where BADGE.NomeNave = NomeNave and BADGE.NumeroPonte = NumeroPonte and BADGE.CodCabina = CodCabina)); 

alter table CABINE add constraint FK_Tipologie
     foreign key (Tipologia)
     references TIPOLOGIE;

alter table CABINE add constraint FK_Ponti
     foreign key (NomeNave, NumeroPonte)
     references PONTI;

alter table INTRATTENIMENTI add constraint FK_Attivit‡
     foreign key (CodAttivit‡)
     references ATTIVIT¿;

alter table INTRATTENIMENTI add constraint FK_Sale
     foreign key (CodSala)
     references SALE;

alter table INTRATTENIMENTI add constraint FK_Navigazioni
     foreign key (CodNavigazione)
     references NAVIGAZIONI;

--alter table NAVI add constraint ID_Navi_CHK
--     check(exists(select * from PONTI
--                  where PONTI.NomeNave = Nome)); 

--alter table NAVI add constraint ID_Navi_CHK
--     check(exists(select * from SCIALUPPE
--                  where SCIALUPPE.NomeNave = Nome)); 

alter table NAVI add constraint FK_Percorsi
     foreign key (CodicePercorso)
     references PERCORSI;

--alter table NAVIGAZIONI add constraint ID_Navigazioni_CHK
--     check(exists(select * from TRATTE_IN_NAVIGAZIONI
--                  where TRATTE_IN_NAVIGAZIONI.CodNavigazione = CodNavigazione)); 

--alter table NAVIGAZIONI add constraint ID_Navigazioni_CHK
--     check(exists(select * from SERVIZI_PERSONALE
--                  where SERVIZI_PERSONALE.CodNavigazione = CodNavigazione)); 

alter table NAVIGAZIONI add constraint FK_Percorsi
     foreign key (CodicePercorso)
     references PERCORSI;

alter table NAVIGAZIONI add constraint FK_Navi
     foreign key (NomeNave)
     references NAVI;

--alter table PAGAMENTI add constraint ID_Pagamenti_CHK
--     check(exists(select * from PRENOTAZIONI
--                  where PRENOTAZIONI.CodTransazione = CodTransazione)); 

--alter table PAGAMENTI add constraint GR_Pagamenti
--     check((NumeroRate is not null and Anticipo is not null)
--           or (NumeroRate is null and Anticipo is null)); 

alter table PASSEGGERI add constraint FK_Badge
     foreign key (CodBadge)
     references BADGE;

--alter table PERCORSI add constraint ID_Percorsi_CHK
--     check(exists(select * from NAVI
--                  where NAVI.CodicePercorso = CodicePercorso)); 

--alter table PERCORSI add constraint ID_Percorsi_CHK
--     check(exists(select * from SEQUENZE
--                  where SEQUENZE.CodicePercorso = CodicePercorso)); 

--alter table PERSONALE add constraint GR_Personale
--     check((Anzianit‡Servizio is not null and Grado is not null)
--           or (Anzianit‡Servizio is null and Grado is null)); 

--alter table PERSONALE add constraint ID_Personale_CHK
--     check(exists(select * from SERVIZI_PERSONALE
--                  where SERVIZI_PERSONALE.CodiceFiscale = CodiceFiscale)); 

--alter table PERSONALE add constraint ID_Personale_CHK
--     check(exists(select * from TURNI_LAVORATIVI
--                  where TURNI_LAVORATIVI.CodiceFiscale = CodiceFiscale)); 

alter table PERSONALE add constraint FK_Ruoli
     foreign key (CodRuolo)
     references RUOLI;

alter table PONTI add constraint FK_Navi
     foreign key (NomeNave)
     references NAVI;

--alter table PRENOTAZIONI add constraint ID_Prenotazioni_CHK
--     check(exists(select * from PRENOTAZIONI_PASSEGGERI
--                  where PRENOTAZIONI_PASSEGGERI.CodicePrenotazione = CodicePrenotazione)); 

alter table PRENOTAZIONI add constraint FK_Pagamenti
     foreign key (CodTransazione)
     references PAGAMENTI;

alter table PRENOTAZIONI add constraint FK_Cabine
     foreign key (NomeNave, NumeroPonte, CodCabina)
     references CABINE;

alter table PRENOTAZIONI add constraint FK_Passeggeri
     foreign key (CodiceFiscale)
     references PASSEGGERI;

alter table PRENOTAZIONI add constraint FK_Tariffari
     foreign key (CodTariffario)
     references TARIFFARI;

alter table PRENOTAZIONI add constraint FK_Navigazioni
     foreign key (CodNavigazione)
     references NAVIGAZIONI;

alter table PRENOTAZIONI add constraint FK_Porti
     foreign key (CodPortoPartenza)
     references PORTI;

alter table PRENOTAZIONI_PASSEGGERI add constraint FK_Prenotazioni
     foreign key (CodicePrenotazione)
     references PRENOTAZIONI;

alter table PRENOTAZIONI_PASSEGGERI add constraint FK_Passeggeri
     foreign key (CodiceFiscale)
     references PASSEGGERI;

alter table RATE add constraint FK_Pagamenti
     foreign key (CodTransazione)
     references PAGAMENTI;

alter table RESPONSABILIT¿ add constraint FK_TurniLavorativo
     foreign key (CodiceFiscale, InizioData, InizioOra)
     references TURNI_LAVORATIVI;

alter table RESPONSABILIT¿ add constraint FK_Responsabilit‡
     foreign key (CodRuolo)
     references RUOLI;

--alter table RUOLI add constraint ID_Ruoli_CHK
--     check(exists(select * from PERSONALE
--                  where PERSONALE.CodRuolo = CodRuolo)); 

--alter table RUOLI add constraint ID_Ruoli_CHK
--     check(exists(select * from RESPONSABILIT¿
--                  where RESPONSABILIT¿.CodRuolo = CodRuolo)); 

alter table SALE add constraint FK_Ponti
     foreign key (NomeNave, NumeroPonte)
     references PONTI;

alter table SCIALUPPE add constraint FK_Navi
     foreign key (NomeNave)
     references NAVI;

alter table SEQUENZE add constraint FK_Percorsi
     foreign key (CodicePercorso)
     references PERCORSI;

alter table SEQUENZE add constraint FK_Tratte
     foreign key (CodTratta)
     references TRATTE;

alter table SERVIZI_PERSONALE add constraint FKSer_PER
     foreign key (CodiceFiscale)
     references PERSONALE;

alter table SERVIZI_PERSONALE add constraint FK_Navigazioni
     foreign key (CodNavigazione)
     references NAVIGAZIONI;

alter table SPESE_EXTRA add constraint FK_Badge
     foreign key (CodBadge)
     references BADGE;

alter table SPESE_EXTRA add constraint FK_Prenotazioni
     foreign key (CodicePrenotazione)
     references PRENOTAZIONI;

alter table TARIFFARI add constraint FK_Nave
     foreign key (NomeNave)
     references NAVI;

alter table TARIFFARI add constraint FK_Tipologie
     foreign key (TipologiaCabina)
     references TIPOLOGIE;

--alter table TRATTE add constraint ID_Tratte_CHK
--     check(exists(select * from SEQUENZE
--                  where SEQUENZE.CodTratta = CodTratta)); 

alter table TRATTE add constraint FK_Porti
     foreign key (CodPortoArrivo)
     references PORTI;

alter table TRATTE add constraint FK_Porti
     foreign key (CodPortoPartenza)
     references PORTI;

alter table TRATTE_IN_NAVIGAZIONI add constraint FK_Tratte
     foreign key (CodTratta)
     references TRATTE;

alter table TRATTE_IN_NAVIGAZIONI add constraint FK_Navigazioni
     foreign key (CodNavigazione)
     references NAVIGAZIONI;

alter table TURNI_LAVORATIVI add constraint FK_Personale
     foreign key (CodiceFiscale)
     references PERSONALE;