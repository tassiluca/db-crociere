-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 11.0.1              
-- * Generator date: Dec  4 2018              
-- * Generation date: Wed Jul 14 21:24:12 2021 
-- * LUN file: C:\Users\lucat\OneDrive - Alma Mater Studiorum Università di Bologna\Uni\basi-di-dati\db-crociere\er\DB-CROCIERE.lun 
-- * Schema: completo-ristrutturato-manina/1 
-- ********************************************* 


-- Database Section
-- ________________ 

create database completo-ristrutturato-manina;


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
     CodAttività -- Sequence attribute not implemented -- not null,
     Nome varchar(20) not null,
     Descrizione varchar(150) not null,
     constraint IDATTIVITÀ primary key (CodAttività));

create table BADGE (
     CodBadge -- Sequence attribute not implemented -- not null,
     CartaCredito char(16) not null,
     NomeNave varchar(30) not null,
     NumeroPonte numeric(2) not null,
     CodCabina numeric(4) not null,
     constraint IDBADGE_ID primary key (CodBadge));

create table CABINA (
     NomeNave varchar(30) not null,
     NumeroPonte numeric(2) not null,
     CodCabina numeric(4) not null,
     Capienza numeric(1) not null,
     Posizione varchar(10) not null,
     Tipologia varchar(7) not null,
     constraint IDCABINA_ID primary key (NomeNave, NumeroPonte, CodCabina));

create table INTRATTENIMENTO (
     Data date not null,
     OrarioInizio date not null,
     CodAttività numeric(5) not null,
     CodSala char(3) not null,
     CodNavigazione numeric(3) not null,
     constraint IDESIBIZIONE primary key (CodNavigazione, CodAttività, Data, OrarioInizio),
     constraint IDESIBIZIONE_2 unique (CodNavigazione, CodAttività, CodSala, Data),
     constraint IDINTRATTENIMENTO unique (CodNavigazione, CodSala, Data, OrarioInizio));

create table NAVE (
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

create table NAVIGAZIONE (
     CodNavigazione -- Sequence attribute not implemented -- not null,
     DataInizio date not null,
     NomeNave varchar(30) not null,
     DataFine date not null,
     NumeroEsecuzioni numeric(2) not null,
     CodicePercorso char(5) not null,
     constraint IDNAVIGAZIONE_1 unique (NomeNave, DataInizio),
     constraint IDNAVIGAZIONE_ID primary key (CodNavigazione));

create table PAGAMENTO (
     CodTransazione -- Sequence attribute not implemented -- not null,
     Data date not null,
     Importo numeric(4) not null,
     NumeroRate numeric(2),
     Anticipo numeric(4),
     constraint IDPAGAMENTO_ID primary key (CodTransazione));

create table PASSEGGERO (
     CodiceFiscale char(16) not null,
     CodBadge numeric(10) not null,
     Nome varchar(30) not null,
     Cognome varchar(40) not null,
     Nazionalità char(3) not null,
     Passaporto char(9) not null,
     constraint IDPASSEGGERO primary key (CodiceFiscale),
     constraint FKPossiede_ID unique (CodBadge));

create table PERCORSO (
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

create table PONTE (
     NomeNave varchar(30) not null,
     Numero numeric(2) not null,
     constraint IDPIANO primary key (NomeNave, Numero));

create table PORTO (
     CodPorto char(4) not null,
     Nazionalità char(3) not null,
     Città varchar(30) not null,
     Prezzo Attracco numeric(4) not null,
     constraint IDPORTO primary key (CodPorto));

create table PRENOTAZIONE (
     CodicePrenotazione -- Sequence attribute not implemented -- not null,
     DataImbarco date not null,
     DataSbarco date not null,
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

create table RATA (
     DataPagamento date not null,
     Importo numeric(4) not null,
     CodTransazione numeric(5) not null,
     constraint IDRATA primary key (DataPagamento));

create table RESPONSABILITÀ (
     CodRuolo char(5) not null,
     CodiceFiscale char(16) not null,
     InizioData date not null,
     InizioOra date not null,
     constraint IDRESPONSABILITÀ primary key (CodRuolo, CodiceFiscale, InizioData, InizioOra));

create table RIMBORSO (
     CodRimborso -- Sequence attribute not implemented -- not null,
     PreavvisoDal char(1) not null,
     PreavvisoAl char(1) not null,
     PercentualeRimborso numeric(3) not null,
     constraint IDRIMBORSO unique (PreavvisoDal, PreavvisoAl),
     constraint IDRIMBORSO_1 primary key (CodRimborso));

create table RUOLO (
     CodRuolo char(5) not null,
     Descrizione varchar(200) not null,
     Nome varchar(30) not null,
     StipendioAnnuo numeric(6) not null,
     constraint IDRUOLO_ID primary key (CodRuolo));

create table SALA (
     CodSala char(3) not null,
     Capienza numeric(4) not null,
     NomeNave varchar(30) not null,
     NumeroPonte numeric(2) not null,
     constraint IDSALA primary key (CodSala));

create table SCIALUPPA (
     CodScialuppa -- Sequence attribute not implemented -- not null,
     DataRevisione date not null,
     Capienza numeric(3) not null,
     NomeNave varchar(30) not null,
     constraint IDSCIALUPPA primary key (CodScialuppa));

create table SEQUENZE (
     CodTratta numeric(3) not null,
     CodicePercorso char(5) not null,
     Ordine numeric(2) not null,
     constraint IDSEQUENZE primary key (CodTratta, CodicePercorso));

create table Servizi (
     CodNavigazione numeric(3) not null,
     CodiceFiscale char(16) not null,
     constraint IDServizi primary key (CodNavigazione, CodiceFiscale));

create table SPESA_EXTRA (
     CodiceSpesa -- Sequence attribute not implemented -- not null,
     Data date not null,
     Importo numeric(3) not null,
     Descrizione varchar(100) not null,
     CodBadge numeric(10) not null,
     CodicePrenotazione numeric(5) not null,
     constraint IDSPESE_EXTRA primary key (CodiceSpesa));

create table TARIFFARIO (
     CodTariffario -- Sequence attribute not implemented -- not null,
     TipologiaCabina varchar(7) not null,
     NomeNave varchar(30) not null,
     DataInizio date not null,
     DataFine date not null,
     Prezzo numeric(4) not null,
     constraint IDTARIFFARIO unique (TipologiaCabina, NomeNave, DataInizio, DataFine),
     constraint IDTARIFFARIO_1 primary key (CodTariffario));

create table TIPOLOGIA (
     Nome varchar(7) not null,
     Prezzo numeric(4) not null,
     Descrizione varchar(100) not null,
     constraint IDTIPOLOGIA primary key (Nome));

create table TRATTA (
     CodTratta -- Sequence attribute not implemented -- not null,
     CodPortoArrivo char(4) not null,
     CodPortoPartenza char(4) not null,
     constraint IDTRATTA_1_ID primary key (CodTratta),
     constraint IDTRATTA unique (CodPortoArrivo, CodPortoPartenza));

create table TRATTA_IN_NAVIGAZIONE (
     CodTrattaNavigazione -- Sequence attribute not implemented -- not null,
     PartenzaData date not null,
     PartenzaOra date not null,
     CodTratta numeric(3) not null,
     CodNavigazione numeric(3) not null,
     ArrivoData date not null,
     ArrivoOra date not null,
     constraint IDTRATTA_IN_NAVIGAZIONE unique (CodTratta, PartenzaData),
     constraint IDTRATTA_IN_NAVIGAZIONE_1 unique (CodNavigazione, PartenzaData, PartenzaOra),
     constraint IDTRATTA_IN_NAVIGAZIONE_2 primary key (CodTrattaNavigazione));

create table TURNO_LAVORATIVO (
     CodiceFiscale char(16) not null,
     InizioData date not null,
     InizioOra date not null,
     FineData date not null,
     FineOra date not null,
     constraint IDTURNO_LAVORATIVO primary key (CodiceFiscale, InizioData, InizioOra));


-- Constraints Section
-- ___________________ 

alter table ANNULLAMENTI add constraint FKAnn_PRE_FK
     foreign key (CodicePrenotazione)
     references PRENOTAZIONE;

alter table ANNULLAMENTI add constraint FKAnn_RIM
     foreign key (CodRimborso)
     references RIMBORSO;

alter table BADGE add constraint IDBADGE_CHK
     check(exists(select * from PASSEGGERO
                  where PASSEGGERO.CodBadge = CodBadge)); 

alter table BADGE add constraint FKRiferimento
     foreign key (NomeNave, NumeroPonte, CodCabina)
     references CABINA;

alter table CABINA add constraint IDCABINA_CHK
     check(exists(select * from BADGE
                  where BADGE.NomeNave = NomeNave and BADGE.NumeroPonte = NumeroPonte and BADGE.CodCabina = CodCabina)); 

alter table CABINA add constraint FKR
     foreign key (Tipologia)
     references TIPOLOGIA;

alter table CABINA add constraint FKOrganizzazione
     foreign key (NomeNave, NumeroPonte)
     references PONTE;

alter table INTRATTENIMENTO add constraint FKAttuazione
     foreign key (CodAttività)
     references ATTIVITÀ;

alter table INTRATTENIMENTO add constraint FKSvolgimento
     foreign key (CodSala)
     references SALA;

alter table INTRATTENIMENTO add constraint FKOfferta
     foreign key (CodNavigazione)
     references NAVIGAZIONE;

alter table NAVE add constraint IDNAVE_CHK
     check(exists(select * from PONTE
                  where PONTE.NomeNave = Nome)); 

alter table NAVE add constraint IDNAVE_CHK
     check(exists(select * from SCIALUPPA
                  where SCIALUPPA.NomeNave = Nome)); 

alter table NAVE add constraint FKAssociata_FK
     foreign key (CodicePercorso)
     references PERCORSO;

alter table NAVIGAZIONE add constraint IDNAVIGAZIONE_CHK
     check(exists(select * from TRATTA_IN_NAVIGAZIONE
                  where TRATTA_IN_NAVIGAZIONE.CodNavigazione = CodNavigazione)); 

alter table NAVIGAZIONE add constraint IDNAVIGAZIONE_CHK
     check(exists(select * from Servizi
                  where Servizi.CodNavigazione = CodNavigazione)); 

alter table NAVIGAZIONE add constraint FKEsecuzione
     foreign key (CodicePercorso)
     references PERCORSO;

alter table NAVIGAZIONE add constraint FKEffettua
     foreign key (NomeNave)
     references NAVE;

alter table PAGAMENTO add constraint IDPAGAMENTO_CHK
     check(exists(select * from PRENOTAZIONE
                  where PRENOTAZIONE.CodTransazione = CodTransazione)); 

alter table PAGAMENTO add constraint GRPAGAMENTO
     check((NumeroRate is not null and Anticipo is not null)
           or (NumeroRate is null and Anticipo is null)); 

alter table PASSEGGERO add constraint FKPossiede_FK
     foreign key (CodBadge)
     references BADGE;

alter table PERCORSO add constraint IDPERCORSO_CHK
     check(exists(select * from NAVE
                  where NAVE.CodicePercorso = CodicePercorso)); 

alter table PERCORSO add constraint IDPERCORSO_CHK
     check(exists(select * from SEQUENZE
                  where SEQUENZE.CodicePercorso = CodicePercorso)); 

alter table PERSONALE add constraint GRPERSONALE
     check((AnzianitàServizio is not null and Grado is not null)
           or (AnzianitàServizio is null and Grado is null)); 

alter table PERSONALE add constraint IDPERSONALE_CHK
     check(exists(select * from Servizi
                  where Servizi.CodiceFiscale = CodiceFiscale)); 

alter table PERSONALE add constraint IDPERSONALE_CHK
     check(exists(select * from TURNO_LAVORATIVO
                  where TURNO_LAVORATIVO.CodiceFiscale = CodiceFiscale)); 

alter table PERSONALE add constraint FKSpecializzazione
     foreign key (CodRuolo)
     references RUOLO;

alter table PONTE add constraint FKCostituita
     foreign key (NomeNave)
     references NAVE;

alter table PRENOTAZIONE add constraint IDPRENOTAZIONE_CHK
     check(exists(select * from PRENOTAZIONI_PASSEGGERI
                  where PRENOTAZIONI_PASSEGGERI.CodicePrenotazione = CodicePrenotazione)); 

alter table PRENOTAZIONE add constraint FKPrevede_FK
     foreign key (CodTransazione)
     references PAGAMENTO;

alter table PRENOTAZIONE add constraint FKAlloggio
     foreign key (NomeNave, NumeroPonte, CodCabina)
     references CABINA;

alter table PRENOTAZIONE add constraint FKNominativo
     foreign key (CodiceFiscale)
     references PASSEGGERO;

alter table PRENOTAZIONE add constraint FKApplicato
     foreign key (CodTariffario)
     references TARIFFARIO;

alter table PRENOTAZIONE add constraint FKRelativa
     foreign key (CodNavigazione)
     references NAVIGAZIONE;

alter table PRENOTAZIONE add constraint FKImbarco
     foreign key (CodPortoPartenza)
     references PORTO;

alter table PRENOTAZIONI_PASSEGGERI add constraint FKCom_PRE
     foreign key (CodicePrenotazione)
     references PRENOTAZIONE;

alter table PRENOTAZIONI_PASSEGGERI add constraint FKCom_PAS
     foreign key (CodiceFiscale)
     references PASSEGGERO;

alter table RATA add constraint FKComposto
     foreign key (CodTransazione)
     references PAGAMENTO;

alter table RESPONSABILITÀ add constraint FKResponsabilitàTurno
     foreign key (CodiceFiscale, InizioData, InizioOra)
     references TURNO_LAVORATIVO;

alter table RESPONSABILITÀ add constraint FKResponsabilitàRuolo
     foreign key (CodRuolo)
     references RUOLO;

alter table RUOLO add constraint IDRUOLO_CHK
     check(exists(select * from PERSONALE
                  where PERSONALE.CodRuolo = CodRuolo)); 

alter table RUOLO add constraint IDRUOLO_CHK
     check(exists(select * from RESPONSABILITÀ
                  where RESPONSABILITÀ.CodRuolo = CodRuolo)); 

alter table SALA add constraint FKDisposizione
     foreign key (NomeNave, NumeroPonte)
     references PONTE;

alter table SCIALUPPA add constraint FKPredisposizione
     foreign key (NomeNave)
     references NAVE;

alter table SEQUENZE add constraint FKSeq_PER
     foreign key (CodicePercorso)
     references PERCORSO;

alter table SEQUENZE add constraint FKSeq_TRA
     foreign key (CodTratta)
     references TRATTA;

alter table Servizi add constraint FKSer_PER
     foreign key (CodiceFiscale)
     references PERSONALE;

alter table Servizi add constraint FKSer_NAV
     foreign key (CodNavigazione)
     references NAVIGAZIONE;

alter table SPESA_EXTRA add constraint FKFattura
     foreign key (CodBadge)
     references BADGE;

alter table SPESA_EXTRA add constraint FKInclusa
     foreign key (CodicePrenotazione)
     references PRENOTAZIONE;

alter table TARIFFARIO add constraint FKCostoNave
     foreign key (NomeNave)
     references NAVE;

alter table TARIFFARIO add constraint FKCostoTipologia
     foreign key (TipologiaCabina)
     references TIPOLOGIA;

alter table TRATTA add constraint IDTRATTA_1_CHK
     check(exists(select * from SEQUENZE
                  where SEQUENZE.CodTratta = CodTratta)); 

alter table TRATTA add constraint FKArrivo
     foreign key (CodPortoArrivo)
     references PORTO;

alter table TRATTA add constraint FKPartenza
     foreign key (CodPortoPartenza)
     references PORTO;

alter table TRATTA_IN_NAVIGAZIONE add constraint FKAttivazione
     foreign key (CodTratta)
     references TRATTA;

alter table TRATTA_IN_NAVIGAZIONE add constraint FKComprende
     foreign key (CodNavigazione)
     references NAVIGAZIONE;

alter table TURNO_LAVORATIVO add constraint FKLavora
     foreign key (CodiceFiscale)
     references PERSONALE;


-- Index Section
-- _____________ 

