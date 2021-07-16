-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 11.0.1              
-- * Generator date: Dec  4 2018              
-- * Generation date: Fri Jul 16 20:40:28 2021 FINAL VERSION
-- * LUN file: C:\Users\lucat\Desktop\db-crociere\er\DB-CROCIERE.lun 
-- * Schema: completo-ristrutturato/1 
-- ********************************************* 


-- Database Section
-- ________________ 

-- create database DbCrociere;
use newtest;

-- DBSpace Section
-- _______________


-- Tables Section
-- _____________ 

create table ANNULLAMENTI (
     CodicePrenotazione numeric(5) not null,
     DataRichiesta date not null,
     CodRimborso numeric(2) not null,
     constraint FKAnn_PRE_ID primary key (CodicePrenotazione));

create table ATTIVITÀ (
     CodAttività numeric(5) identity(1,1) not null,
     Nome varchar(20) not null,
     Descrizione varchar(150) not null,
     constraint IDATTIVITÀ primary key (CodAttività));

create table BADGE (
     CodBadge numeric(10) identity(1,1) not null,
     CartaCredito char(16) not null,
     NomeNave varchar(30) not null,
     NumeroPonte numeric(2) not null,
     CodCabina numeric(4) not null,
     constraint IDBADGE_ID primary key (CodBadge));

create table CABINE (
     NomeNave varchar(30) not null,
     NumeroPonte numeric(2) not null,
     CodCabina numeric(4) not null,
     Capienza numeric(1) not null,
     Posizione varchar(10) not null,
     Tipologia varchar(7) not null,
     constraint IDCABINA_ID primary key (NomeNave, NumeroPonte, CodCabina));

create table INTRATTENIMENTI (
     CodAttività numeric(5) not null,
     DataInizio date not null,
     OrarioInizio time not null,
     CodSala char(3) not null,
     CodNavigazione numeric(3) not null,
     constraint IDINTRATTENIMENTO primary key (CodAttività, CodNavigazione, DataInizio, OrarioInizio),
     constraint IDINTRATTENIMENTO_1 unique (CodNavigazione, CodSala, DataInizio, OrarioInizio));

create table NAVI (
     Nome varchar(30) not null,
     CodNave char(5) not null,
     CodicePercorso char(5) not null,
     Larghezza numeric(3) not null,
     Lunghezza numeric(3) not null,
     Peso numeric(6) not null,
     Altezza numeric(3) not null,
     NumeroCabine numeric(4) not null,
     constraint IDNAVE_ID primary key (Nome),
     constraint IDNAVE_1 unique (CodNave),
     constraint FKAssociata_ID unique (CodicePercorso));

create table NAVIGAZIONI (
     CodNavigazione numeric(3) identity(1,1) not null,
     DataInizio date not null,
     NomeNave varchar(30) not null,
     DataFine date not null,
     NumeroEsecuzioni numeric(2) not null,
     CodicePercorso char(5) not null,
     constraint IDNAVIGAZIONE_1 unique (NomeNave, DataInizio),
     constraint IDNAVIGAZIONE_ID primary key (CodNavigazione));

create table PAGAMENTI (
     CodTransazione numeric(5) identity(1,1) not null,
     DataTransazione date not null,
     Importo numeric(4) not null,
     NumeroRate numeric(2),
     Anticipo numeric(4),
     constraint IDPAGAMENTO_ID primary key (CodTransazione));

create table PASSEGGERI (
     CodiceFiscale char(16) not null,
     CodBadge numeric(10) not null,
     Nome varchar(30) not null,
     Cognome varchar(40) not null,
     Nazionalità char(3) not null,
     Passaporto char(9) not null,
     constraint IDPASSEGGERO primary key (CodiceFiscale),
     constraint FKPossiede_ID unique (CodBadge));

create table PERCORSI (
     CodicePercorso char(5) not null,
     GiorniDurata numeric(2) not null,
     constraint IDPERCORSO_ID primary key (CodicePercorso));

create table PERSONALE (
     CodiceFiscale char(16) not null,
     Nome varchar(30) not null,
     Cognome varchar(40) not null,
     Nazionalità char(3) not null,
     Passaporto char(9) not null,
     Recapito numeric(14) not null,
     AnzianitàServizio numeric(2),
     Grado varchar(20),
     CodRuolo char(5) not null,
     constraint IDPERSONALE_ID primary key (CodiceFiscale));

create table PONTI (
     NomeNave varchar(30) not null,
     Numero numeric(2) not null,
     constraint IDPIANO primary key (NomeNave, Numero));

create table PORTI (
     CodPorto char(4) not null,
     Nazionalità char(3) not null,
     Città varchar(30) not null,
     PrezzoAttracco numeric(4) not null,
     constraint IDPORTO primary key (CodPorto));

create table PRENOTAZIONI (
     CodicePrenotazione numeric(5) identity(1,1) not null,
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
     constraint IDPRENOTAZIONE_ID primary key (CodicePrenotazione),
     constraint IDPRENOTAZIONE_1 unique (CodiceFiscale, DataImbarco, DataSbarco),
     constraint IDPRENOTAZIONE_2 unique (NomeNave, NumeroPonte, CodCabina, DataImbarco, DataSbarco),
     constraint FKPrevede_ID unique (CodTransazione));

create table PRENOTAZIONI_PASSEGGERI (
     CodiceFiscale char(16) not null,
     CodicePrenotazione numeric(5) not null,
     constraint IDPRENOTAZIONI_PASSEGGERI primary key (CodiceFiscale, CodicePrenotazione));

create table RATE (
     DataPagamento datetime not null,
     Importo numeric(4) not null,
     CodTransazione numeric(5) not null,
     constraint IDRATA primary key (DataPagamento));

create table RESPONSABILITÀ (
     CodRuolo char(5) not null,
     CodiceFiscale char(16) not null,
     InizioData date not null,
     InizioOra time not null,
     constraint IDRESPONSABILITÀ primary key (CodRuolo, CodiceFiscale, InizioData, InizioOra));

create table RIMBORSI (
     CodRimborso numeric(2) identity(1,1) not null,
     PreavvisoDal char(1) not null,
     PreavvisoAl char(1) not null,
     PercentualeRimborso numeric(3) not null,
     constraint IDRIMBORSO unique (PreavvisoDal, PreavvisoAl),
     constraint IDRIMBORSO_1 primary key (CodRimborso));

create table RUOLI (
     CodRuolo char(5) not null,
     Descrizione varchar(200) not null,
     Nome varchar(30) not null,
     StipendioAnnuo numeric(6) not null,
     constraint IDRUOLO_ID primary key (CodRuolo));

create table SALE (
     CodSala char(3) not null,
     Capienza numeric(4) not null,
     NomeNave varchar(30) not null,
     NumeroPonte numeric(2) not null,
     constraint IDSALA primary key (CodSala));

create table SCIALUPPE (
     CodScialuppa numeric(2) identity(1,1) not null,
     DataRevisione date not null,
     Capienza numeric(3) not null,
     NomeNave varchar(30) not null,
     constraint IDSCIALUPPA primary key (CodScialuppa));

create table SEQUENZE (
     CodTratta numeric(3) not null,
     CodicePercorso char(5) not null,
     Ordine numeric(2) not null,
     constraint IDSEQUENZE primary key (CodTratta, CodicePercorso));

create table SERVIZI (
     CodNavigazione numeric(3) not null,
     CodiceFiscale char(16) not null,
     constraint IDServizi primary key (CodNavigazione, CodiceFiscale));

create table SPESE_EXTRA (
     CodiceSpesa numeric(5) identity(1,1) not null,
     DataSpesa datetime not null,
     Importo numeric(3) not null,
     Descrizione varchar(100) not null,
     CodBadge numeric(10) not null,
     CodicePrenotazione numeric(5) not null,
     constraint IDSPESE_EXTRA primary key (CodiceSpesa));

create table TARIFFARI (
     CodTariffario numeric(3) identity(1,1) not null,
     TipologiaCabina varchar(7) not null,
     NomeNave varchar(30) not null,
     DataInizio date not null,
     DataFine date not null,
     Prezzo numeric(4) not null,
     constraint IDTARIFFARIO unique (TipologiaCabina, NomeNave, DataInizio, DataFine),
     constraint IDTARIFFARIO_1 primary key (CodTariffario));

create table TIPOLOGIE (
     Nome varchar(7) not null,
     Prezzo numeric(4) not null,
     Descrizione varchar(100) not null,
     constraint IDTIPOLOGIA primary key (Nome));

create table TRATTE (
     CodTratta numeric(3) identity(1,1) not null,
     CodPortoArrivo char(4) not null,
     CodPortoPartenza char(4) not null,
     constraint IDTRATTA_1_ID primary key (CodTratta),
     constraint IDTRATTA unique (CodPortoArrivo, CodPortoPartenza));

create table TRATTE_IN_NAVIGAZIONE (
     CodTrattaNavigazione numeric(5) identity(1,1) not null,
     PartenzaData datetime not null,
     PartenzaOra datetime not null,
     CodTratta numeric(3) not null,
     CodNavigazione numeric(3) not null,
     ArrivoData datetime not null,
     ArrivoOra datetime not null,
     constraint IDTRATTA_IN_NAVIGAZIONE unique (CodTratta, PartenzaData),
     constraint IDTRATTA_IN_NAVIGAZIONE_1 unique (CodNavigazione, PartenzaData, PartenzaOra),
     constraint IDTRATTA_IN_NAVIGAZIONE_2 primary key (CodTrattaNavigazione));

create table TURNI_LAVORATIVI (
     CodiceFiscale char(16) not null,
     InizioData date not null,
     InizioOra time not null,
     FineData date not null,
     FineOra time not null,
     constraint IDTURNO_LAVORATIVO primary key (CodiceFiscale, InizioData, InizioOra));

-- Functions
-- ___________________
GO
CREATE FUNCTION idBadgeChk(@badge numeric(10))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct CodBadge) from PASSEGGERI where PASSEGGERI.CodBadge = @badge)
END;
GO

GO
CREATE FUNCTION idCabinaChk(@NomeNave varchar(30), @NumeroPonte numeric(2), @CodCabina numeric(4))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct CodBadge) from BADGE where BADGE.NomeNave = @NomeNave and BADGE.NumeroPonte = @NumeroPonte and BADGE.CodCabina = @CodCabina)
END;
GO

GO
CREATE FUNCTION idNavePontiChk(@NomeNave varchar(30))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct NomeNave) from PONTI where PONTI.NomeNave = @NomeNave)
END;
GO

GO
CREATE FUNCTION idNaveScialuppeChk(@NomeNave varchar(30))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct NomeNave) from SCIALUPPE where SCIALUPPE.NomeNave = @NomeNave)
END;
GO

GO
CREATE FUNCTION idNavigazioneTratteChk(@CodNavigazione numeric(3))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct CodNavigazione) from TRATTE_IN_NAVIGAZIONE where TRATTE_IN_NAVIGAZIONE.CodNavigazione = @CodNavigazione)
END;
GO

GO
CREATE FUNCTION idNavigazioneServiziChk(@CodNavigazione numeric(3))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct CodNavigazione) from SERVIZI where SERVIZI.CodNavigazione = @CodNavigazione)
END;
GO

GO
CREATE FUNCTION idPagamentiPrenotazioniChk(@CodTransazione numeric(5))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct CodTransazione) from PRENOTAZIONI where PRENOTAZIONI.CodTransazione = @CodTransazione)
END;
GO

GO
CREATE FUNCTION idPercorsiNaviChk(@CodicePercorso char(5))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct CodicePercorso) from NAVI where NAVI.CodicePercorso = @CodicePercorso)
END;
GO

GO
CREATE FUNCTION idPercorsiSequenzeChk(@CodicePercorso char(5))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct CodicePercorso) from SEQUENZE where SEQUENZE.CodicePercorso = @CodicePercorso)
END;
GO

GO
CREATE FUNCTION idPersonaleServiziChk(@CodiceFiscale char(16))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct CodiceFiscale) from SERVIZI where SERVIZI.CodiceFiscale = @CodiceFiscale)
END;
GO

GO
CREATE FUNCTION idPersonaleTurniChk(@CodiceFiscale char(16))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct CodiceFiscale) from TURNI_LAVORATIVI where TURNI_LAVORATIVI.CodiceFiscale = @CodiceFiscale)
END;
GO

GO
CREATE FUNCTION idPrenotazioniPasseggeriChk(@CodicePrenotazione numeric(5))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct CodicePrenotazione) from PRENOTAZIONI_PASSEGGERI where PRENOTAZIONI_PASSEGGERI.CodicePrenotazione = @CodicePrenotazione)
END;
GO

GO
CREATE FUNCTION idRuoliPersonaleChk(@CodRuolo char(5))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct CodRuolo) from PERSONALE where PERSONALE.CodRuolo = @CodRuolo)
END;
GO

GO
CREATE FUNCTION idRuoliResponsabilitàChk(@CodRuolo char(5))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct CodRuolo) from RESPONSABILITÀ where RESPONSABILITÀ.CodRuolo = @CodRuolo)
END;
GO

GO
CREATE FUNCTION idTratteSequenzeChk(@CodTratta numeric(3))
RETURNS numeric(1)
AS
BEGIN
RETURN (select count(distinct CodTratta) from SEQUENZE where SEQUENZE.CodTratta = @CodTratta)
END;
GO

-- Constraints Section
-- ___________________ 

alter table ANNULLAMENTI add constraint FKAnn_PRE_FK
     foreign key (CodicePrenotazione)
     references PRENOTAZIONI;

alter table ANNULLAMENTI add constraint FKAnn_RIM
     foreign key (CodRimborso)
     references RIMBORSI;

alter table BADGE add constraint IDBADGE_CHK
     check(dbo.idBadgeChk(CodBadge) > 0); 

alter table BADGE add constraint FKRiferimento
     foreign key (NomeNave, NumeroPonte, CodCabina)
     references CABINE;

alter table CABINE add constraint IDCABINA_CHK
     check(dbo.idCabinaChk(NomeNave, NumeroPonte, CodCabina) > 0); 

alter table CABINE add constraint FKR
     foreign key (Tipologia)
     references TIPOLOGIE;

alter table CABINE add constraint FKOrganizzazione
     foreign key (NomeNave, NumeroPonte)
     references PONTI;

alter table INTRATTENIMENTI add constraint FKSvolgimento
     foreign key (CodSala)
     references SALE;

alter table INTRATTENIMENTI add constraint FKAttuazione
     foreign key (CodAttività)
     references ATTIVITÀ;

alter table INTRATTENIMENTI add constraint FKOfferta
     foreign key (CodNavigazione)
     references NAVIGAZIONI;

alter table NAVI add constraint IDNAVEPONTI_CHK
	  check(dbo.idNavePontiChk(Nome) > 0);

alter table NAVI add constraint IDNAVESCIALUPPE_CHK
	  check(dbo.idNaveScialuppeChk(Nome) > 0);

alter table NAVI add constraint FKAssociata_FK
     foreign key (CodicePercorso)
     references PERCORSI;

alter table NAVIGAZIONI add constraint IDNAVIGAZIONETRATTE_CHK
	  check(dbo.idNavigazioneTratteChk(CodNavigazione) > 0);

alter table NAVIGAZIONI add constraint IDNAVIGAZIONESERVIZI_CHK
	  check(dbo.idNavigazioneServiziChk(CodNavigazione) > 0);

alter table NAVIGAZIONI add constraint FKEsecuzione
     foreign key (CodicePercorso)
     references PERCORSI;

alter table NAVIGAZIONI add constraint FKEffettua
     foreign key (NomeNave)
     references NAVI;

alter table PAGAMENTI add constraint IDPAGAMENTO_CHK
	 check(dbo.idPagamentiPrenotazioniChk(CodTransazione) > 0);

alter table PAGAMENTI add constraint GRPAGAMENTO
     check((NumeroRate is not null and Anticipo is not null)
           or (NumeroRate is null and Anticipo is null)); 

alter table PASSEGGERI add constraint FKPossiede_FK
     foreign key (CodBadge)
     references BADGE;

alter table PERCORSI add constraint IDPERCORSONAVI_CHK
	 check(dbo.idPercorsiNaviChk(CodicePercorso) > 0);

alter table PERCORSI add constraint IDPERCORSOSEQUENZE_CHK
	  check(dbo.idPercorsiSequenzeChk(CodicePercorso) > 0)

alter table PERSONALE add constraint GRPERSONALE
     check((AnzianitàServizio is not null and Grado is not null)
           or (AnzianitàServizio is null and Grado is null)); 

alter table PERSONALE add constraint IDPERSONALESERVIZI_CHK
	 check(dbo.idPersonaleServiziChk(CodiceFiscale) > 0);

alter table PERSONALE add constraint IDPERSONALETURNI_CHK
	  check(dbo.idPersonaleTurniChk(CodiceFiscale) > 0);

alter table PERSONALE add constraint FKSpecializzazione
     foreign key (CodRuolo)
     references RUOLI;

alter table PONTI add constraint FKCostituita
     foreign key (NomeNave)
     references NAVI;

alter table PRENOTAZIONI add constraint IDPRENOTAZIONE_CHK
	  check(dbo.idPrenotazioniPasseggeriChk(CodicePrenotazione) > 0)

alter table PRENOTAZIONI add constraint FKPrevede_FK
     foreign key (CodTransazione)
     references PAGAMENTI;

alter table PRENOTAZIONI add constraint FKAlloggio
     foreign key (NomeNave, NumeroPonte, CodCabina)
     references CABINE;

alter table PRENOTAZIONI add constraint FKNominativo
     foreign key (CodiceFiscale)
     references PASSEGGERI;

alter table PRENOTAZIONI add constraint FKApplicato
     foreign key (CodTariffario)
     references TARIFFARI;

alter table PRENOTAZIONI add constraint FKRelativa
     foreign key (CodNavigazione)
     references NAVIGAZIONI;

alter table PRENOTAZIONI add constraint FKImbarco
     foreign key (CodPortoPartenza)
     references PORTI;

alter table PRENOTAZIONI_PASSEGGERI add constraint FKCom_PRE
     foreign key (CodicePrenotazione)
     references PRENOTAZIONI;

alter table PRENOTAZIONI_PASSEGGERI add constraint FKCom_PAS
     foreign key (CodiceFiscale)
     references PASSEGGERI;

alter table RATE add constraint FKComposto
     foreign key (CodTransazione)
     references PAGAMENTI;

alter table RESPONSABILITÀ add constraint FKResponsabilitàTurno
     foreign key (CodiceFiscale, InizioData, InizioOra)
     references TURNI_LAVORATIVI;

alter table RESPONSABILITÀ add constraint FKResponsabilitàRuolo
     foreign key (CodRuolo)
     references RUOLI;

alter table RUOLI add constraint IDRUOLOPERSONALE_CHK
	  check(dbo.idRuoliPersonaleChk(CodRuolo) > 0);

alter table RUOLI add constraint IDRUOLORESP_CHK
	  check(dbo.idRuoliResponsabilitàChk(CodRuolo) > 0);

alter table SALE add constraint FKDisposizione
     foreign key (NomeNave, NumeroPonte)
     references PONTI;

alter table SCIALUPPE add constraint FKPredisposizione
     foreign key (NomeNave)
     references NAVI;

alter table SEQUENZE add constraint FKSeq_PER
     foreign key (CodicePercorso)
     references PERCORSI;

alter table SEQUENZE add constraint FKSeq_TRA
     foreign key (CodTratta)
     references TRATTE;

alter table SERVIZI add constraint FKSer_PER
     foreign key (CodiceFiscale)
     references PERSONALE;

alter table SERVIZI add constraint FKSer_NAV
     foreign key (CodNavigazione)
     references NAVIGAZIONI;

alter table SPESE_EXTRA add constraint FKFattura
     foreign key (CodBadge)
     references BADGE;

alter table SPESE_EXTRA add constraint FKInclusa
     foreign key (CodicePrenotazione)
     references PRENOTAZIONI;

alter table TARIFFARI add constraint FKCostoNave
     foreign key (NomeNave)
     references NAVI;

alter table TARIFFARI add constraint FKCostoTipologia
     foreign key (TipologiaCabina)
     references TIPOLOGIE;

alter table TRATTE add constraint IDTRATTA_1_CHK
	  check(dbo.idTratteSequenzeChk(CodTratta) > 0);

alter table TRATTE add constraint FKArrivo
     foreign key (CodPortoArrivo)
     references PORTI;

alter table TRATTE add constraint FKPartenza
     foreign key (CodPortoPartenza)
     references PORTI;

alter table TRATTE_IN_NAVIGAZIONE add constraint FKAttivazione
     foreign key (CodTratta)
     references TRATTE;

alter table TRATTE_IN_NAVIGAZIONE add constraint FKComprende
     foreign key (CodNavigazione)
     references NAVIGAZIONI;

alter table TURNI_LAVORATIVI add constraint FKLavora
     foreign key (CodiceFiscale)
     references PERSONALE;


-- Index Section
-- _____________ 

