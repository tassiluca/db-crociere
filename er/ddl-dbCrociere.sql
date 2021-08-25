-- *********************************************
-- * SQL SERVER DDL              
-- *--------------------------------------------           
-- * Generation date: Wed Aug 25 20:00 2021 
-- ********************************************* 


-- Database Section
-- ________________ 

use dbCrociere;


-- DBSpace Section
-- _______________


-- Tables Section
-- _____________ 

create table ALLOGGI (
     CodPrenotazione numeric(5) not null,
     CodCabina numeric(5) not null,
     constraint IDALLOGGI primary key (CodCabina, CodPrenotazione));

create table ANNULLAMENTI (
     CodPrenotazione numeric(5) not null,
     DataRichiesta date not null,
     CodRimborso numeric(2) not null,
     constraint FKAnn_PRE_ID primary key (CodPrenotazione));

create table ATTIVIT¿ (
     CodAttivit‡ numeric(5) identity(1,1) not null,
     Nome varchar(20) not null,
     Descrizione varchar(150),
     constraint IDATTIVIT¿ primary key (CodAttivit‡));

create table BADGE (
     CodBadge numeric(10) identity(1,1) not null,
     CodPrenotazione numeric(5) not null,
     CodiceFiscale char(16) not null,
     CartaCredito char(16) not null,
     constraint IDBADGE primary key (CodBadge),
     constraint IDBADGE_1 unique (CodiceFiscale, CodPrenotazione));

create table CABINE (
     CodCabina numeric(5) identity(1,1) not null,
     NomeNave varchar(30) not null,
     NumeroPonte numeric(2) not null,
     NumeroLocale numeric(3) not null,
     PostiLetto numeric(1) not null,
     Posizione varchar(10) not null,
     NomeTipologia varchar(7) not null,
     constraint IDCABINA unique (NomeNave, NumeroPonte, NumeroLocale),
     constraint IDCABINA_1 primary key (CodCabina));

create table ESECUZIONI_TRATTA (
     CodTratta numeric(3) not null,
     Partenza_Data date not null,
     Partenza_Ora time not null,
     Arrivo_Data date not null,
     Arrivo_Ora time not null,
     CodNavigazione numeric(3) not null,
     constraint IDESECUZIONE_TRATTA primary key (CodTratta, CodNavigazione, Partenza_Data),
     constraint IDESECUZIONE_TRATTA_1 unique (CodNavigazione, Partenza_Data, Partenza_Ora),
     constraint IDESECUZIONE_TRATTA_2 unique (CodNavigazione, Arrivo_Data, Arrivo_Ora));

create table NAVI (
     Nome varchar(30) not null,
     CodNave numeric(2) identity(1,1) not null,
     Larghezza numeric(3) not null,
     Lunghezza numeric(3) not null,
     Peso numeric(6) not null,
     Altezza numeric(3) not null,
     NumeroCabine numeric(4) not null,
     constraint IDNAVE primary key (Nome),
     constraint IDNAVE_1 unique (CodNave));

create table NAVIGAZIONI (
     CodNavigazione numeric(3) identity(1,1) not null,
     NomeNave varchar(30) not null,
     DataInizio date not null,
     DataFine date not null,
     NumeroEsecuzioni numeric(2) not null,
     CodPercorso char(5) not null,
     constraint IDNAVIGAZIONE_1 unique (NomeNave, DataInizio),
     constraint IDNAVIGAZIONI primary key (CodNavigazione));

create table PAGAMENTI (
     CodTransazione numeric(5) identity(1,1) not null,
     DataPagamento date not null,
     Importo numeric(4) not null,
     NumeroRate numeric(2),
     Anticipo numeric(4),
     constraint IDPAGAMENTO primary key (CodTransazione));

create table PASSEGGERI (
     CodiceFiscale char(16) not null,
     Nome varchar(30) not null,
     Cognome varchar(40) not null,
     Nazionalit‡ char(3) not null,
     Passaporto char(9) not null,
     constraint IDPASSEGGERO primary key (CodiceFiscale));

create table PERCORSI (
     CodPercorso char(5) not null,
     NomeNave varchar(30) not null,
     GiorniDurata numeric(2) not null,
     constraint IDPERCORSO_ID primary key (CodPercorso),
     constraint FKAssociata_ID unique (NomeNave));

create table PERSONALE (
     CodiceFiscale char(16) not null,
     Nome varchar(30) not null,
     Cognome varchar(40) not null,
     Nazionalit‡ char(3) not null,
     Passaporto char(9) not null,
     Recapito numeric(14) not null,
     StipendioAnnuo numeric(6) not null,
     Anzianit‡Servizio numeric(2),
     Grado varchar(20),
     CodRuolo char(5) not null,
     constraint IDPERSONALE primary key (CodiceFiscale));

create table PONTI (
     NomeNave varchar(30) not null,
     Numero numeric(2) not null,
     constraint IDPIANO primary key (NomeNave, Numero));

create table PORTI (
     CodPorto char(4) not null,
     Nazionalit‡ char(3) not null,
     Citt‡ varchar(30) not null,
     PrezzoAttracco numeric(4) not null,
     constraint IDPORTO primary key (CodPorto));

create table PRENOTAZIONI (
     CodPrenotazione numeric(5) identity(1,1) not null,
     CodTransazione numeric(5) not null,
     DataEffettuazione date not null,
     DataOraImbarco datetime not null,
     DataOraSbarco datetime not null,
     Trattamento varchar(13) not null,
     NumeroPasseggeri numeric(2) not null,
     CodNavigazione numeric(3) not null,
     CodPorto char(4) not null,
     constraint IDPRENOTAZIONE_ID primary key (CodPrenotazione),
     constraint FKPrevede_ID unique (CodTransazione));

create table PRENOTAZIONI_PASSEGGERI (
     CodiceFiscale char(16) not null,
     CodPrenotazione numeric(5) not null,
     constraint IDPRENOTAZIONI_PASSEGGERI primary key (CodiceFiscale, CodPrenotazione));

create table PROGRAMMAZIONI (
     InizioData date not null,
     InizioOra time not null,
     CodSala numeric(3) not null,
     CodAttivit‡ numeric(5) not null,
     CodNavigazione numeric(3) not null,
     Durata numeric(3) not null,
     constraint IDINTRATTENIMENTO primary key (CodNavigazione, CodSala, InizioData, InizioOra),
     constraint IDINTRATTENIMENTO_1 unique (CodAttivit‡, CodNavigazione, CodSala, InizioData));

create table RATE (
     DataPagamento date not null,
     Importo numeric(4) not null,
     CodTransazione numeric(5) not null,
     constraint IDRATA primary key (DataPagamento));

create table RESPONSABILIT¿ (
     CodNavigazione numeric(3) not null,
     CodRuolo char(5) not null,
     CodiceFiscale char(16) not null,
     constraint IDRESPONSABILIT¿ primary key (CodNavigazione, CodRuolo));

create table RIMBORSI (
     CodRimborso numeric(2) identity(1,1) not null,
     Preavviso_Dal numeric(3) not null,
     Preavviso_Al numeric(3) not null,
     PercentualeRimborso numeric(3) not null,
     constraint IDRIMBORSO unique (Preavviso_Dal, Preavviso_Al),
     constraint IDRIMBORSO_1 primary key (CodRimborso));

create table RUOLI (
     CodRuolo char(5) not null,
     Descrizione varchar(200),
     Nome varchar(30) not null,
     constraint IDRUOLO primary key (CodRuolo));

create table SALE (
     CodSala numeric(3) identity(1,1) not null,
     NomeNave varchar(30) not null,
     NumeroPonte numeric(2) not null,
     NumeroLocale numeric(3) not null,
     Capienza numeric(4) not null,
     constraint IDSALA unique (NomeNave, NumeroPonte, NumeroLocale),
     constraint IDSALA_1 primary key (CodSala));

create table SCIALUPPE (
     CodScialuppa numeric(3) identity(1,1) not null,
     DataRevisione date not null,
     Capienza numeric(3) not null,
     NomeNave varchar(30) not null,
     constraint IDSCIALUPPA primary key (CodScialuppa));

create table SEQUENZE_TRATTE (
     CodPercorso char(5) not null,
     CodTratta numeric(3) not null,
     Ordine numeric(2) not null,
     constraint IDSEQUENZA_TRATTE primary key (CodTratta, CodPercorso));

create table SERVIZI (
     CodNavigazione numeric(3) not null,
     CodiceFiscale char(16) not null,
     constraint IDSERVIZI primary key (CodNavigazione, CodiceFiscale));

create table SPESE_EXTRA (
     CodiceSpesa numeric(5) identity(1,1) not null,
     DataSpesa date not null,
     Importo numeric(3) not null,
     Descrizione varchar(100) not null,
     CodPrenotazione numeric(5) not null,
     CodBadge numeric(10) not null,
     constraint IDSPESE_EXTRA primary key (CodiceSpesa));

create table TARIFFARI (
     CodTariffario numeric(3) identity(1,1) not null,
     NomeNave varchar(30) not null,
     NomeTipologia varchar(7) not null,
     DataInizio date not null,
     DataFine date not null,
     Prezzo numeric(4) not null,
     constraint IDTARIFFARIO unique (NomeTipologia, NomeNave, DataInizio, DataFine),
     constraint IDTARIFFARIO_1 primary key (CodTariffario));

create table TARIFFARI_PRENOTAZIONI (
     CodTariffario numeric(3) not null,
     CodPrenotazione numeric(5) not null,
     constraint IDTARIFFARI_PRENOTAZIONI primary key (CodTariffario, CodPrenotazione));

create table TIPOLOGIE (
     Nome varchar(7) not null,
     Prezzo numeric(4) not null,
     Descrizione varchar(100),
     constraint IDTIPOLOGIA primary key (Nome));

create table TRATTE (
     CodTratta numeric(3) identity(1,1) not null,
     CodPortoArrivo char(4) not null,
     CodPortoPartenza char(4) not null,
     constraint IDTRATTA_1 primary key (CodTratta),
     constraint IDTRATTA unique (CodPortoArrivo, CodPortoPartenza));

create table TURNI_LAVORATIVI (
     CodiceFiscale char(16) not null,
     DataOraInizio datetime not null,
     DataOraFine datetime not null,
     constraint IDTURNO_LAVORATIVO primary key (CodiceFiscale, DataOraInizio));


-- Constraints Section
-- ___________________ 

alter table ALLOGGI add constraint FKAll_CAB
     foreign key (CodCabina)
     references CABINE;

alter table ALLOGGI add constraint FKAll_PRE
     foreign key (CodPrenotazione)
     references PRENOTAZIONI;

alter table ANNULLAMENTI add constraint FKAnn_PRE_FK
     foreign key (CodPrenotazione)
     references PRENOTAZIONI;

alter table ANNULLAMENTI add constraint FKAnn_RIM
     foreign key (CodRimborso)
     references RIMBORSI;

alter table BADGE add constraint FKRacchiude
     foreign key (CodPrenotazione)
     references PRENOTAZIONI;

alter table BADGE add constraint FKPossiede
     foreign key (CodiceFiscale)
     references PASSEGGERI;

alter table CABINE add constraint FKOrganizzazioneCabina
     foreign key (NomeNave, NumeroPonte)
     references PONTI;

alter table CABINE add constraint FKDi
     foreign key (NomeTipologia)
     references TIPOLOGIE;

alter table ESECUZIONI_TRATTA add constraint FKComprende
     foreign key (CodNavigazione)
     references NAVIGAZIONI;

alter table ESECUZIONI_TRATTA add constraint FKAttivazione
     foreign key (CodTratta)
     references TRATTE;

alter table NAVIGAZIONI add constraint FKEsecuzione
     foreign key (CodPercorso)
     references PERCORSI;

alter table NAVIGAZIONI add constraint FKEffettua
     foreign key (NomeNave)
     references NAVI;

alter table PAGAMENTI add constraint GRPAGAMENTO
     check((NumeroRate is not null and Anticipo is not null)
           or (NumeroRate is null and Anticipo is null)); 

--alter table PERCORSI add constraint IDPERCORSO_CHK
--     check(exists(select * from SEQUENZE_TRATTE
--                  where SEQUENZE_TRATTE.CodPercorso = CodPercorso)); 

alter table PERCORSI add constraint FKAssociata_FK
     foreign key (NomeNave)
     references NAVI;

alter table PERSONALE add constraint GRPERSONALE
     check((Anzianit‡Servizio is not null and Grado is not null)
           or (Anzianit‡Servizio is null and Grado is null)); 

alter table PERSONALE add constraint FKSpecializzazione
     foreign key (CodRuolo)
     references RUOLI;

alter table PONTI add constraint FKCostituita
     foreign key (NomeNave)
     references NAVI;

--alter table PRENOTAZIONI add constraint IDPRENOTAZIONE_CHK
--     check(exists(select * from PRENOTAZIONI_PASSEGGERI
--                  where PRENOTAZIONI_PASSEGGERI.CodPrenotazione = CodPrenotazione)); 

--alter table PRENOTAZIONI add constraint IDPRENOTAZIONE_CHK
--     check(exists(select * from ALLOGGI
--                  where ALLOGGI.CodPrenotazione = CodPrenotazione)); 

--alter table PRENOTAZIONI add constraint IDPRENOTAZIONE_CHK
--     check(exists(select * from TARIFFARI_PRENOTAZIONI
--                  where TARIFFARI_PRENOTAZIONI.CodPrenotazione = CodPrenotazione)); 

alter table PRENOTAZIONI add constraint FKRelativa
     foreign key (CodNavigazione)
     references NAVIGAZIONI;

alter table PRENOTAZIONI add constraint FKImbarcoSbarco
     foreign key (CodPorto)
     references PORTI;

alter table PRENOTAZIONI add constraint FKPrevede_FK
     foreign key (CodTransazione)
     references PAGAMENTI;

alter table PRENOTAZIONI_PASSEGGERI add constraint FKCom_PRE
     foreign key (CodPrenotazione)
     references PRENOTAZIONI;

alter table PRENOTAZIONI_PASSEGGERI add constraint FKCom_PAS
     foreign key (CodiceFiscale)
     references PASSEGGERI;

alter table PROGRAMMAZIONI add constraint FKSvolgimento
     foreign key (CodSala)
     references SALE;

alter table PROGRAMMAZIONI add constraint FKAttuazione
     foreign key (CodAttivit‡)
     references ATTIVIT¿;

alter table PROGRAMMAZIONI add constraint FKOfferta
     foreign key (CodNavigazione)
     references NAVIGAZIONI;

alter table RATE add constraint FKComposto
     foreign key (CodTransazione)
     references PAGAMENTI;

alter table RESPONSABILIT¿ add constraint FKResponsabilit‡Personale
     foreign key (CodiceFiscale)
     references PERSONALE;

alter table RESPONSABILIT¿ add constraint FKResponsabilit‡Ruolo
     foreign key (CodRuolo)
     references RUOLI;

alter table RESPONSABILIT¿ add constraint FKResponsabilit‡Navigazione
     foreign key (CodNavigazione)
     references NAVIGAZIONI;

alter table SALE add constraint FKOrganizzazioneSala
     foreign key (NomeNave, NumeroPonte)
     references PONTI;

alter table SCIALUPPE add constraint FKPredisposizione
     foreign key (NomeNave)
     references NAVI;

alter table SEQUENZE_TRATTE add constraint FKSeq_TRA
     foreign key (CodTratta)
     references TRATTE;

alter table SEQUENZE_TRATTE add constraint FKSeq_PER
     foreign key (CodPercorso)
     references PERCORSI;

alter table SERVIZI add constraint FKSer_PER
     foreign key (CodiceFiscale)
     references PERSONALE;

alter table SERVIZI add constraint FKSer_NAV
     foreign key (CodNavigazione)
     references NAVIGAZIONI;

alter table SPESE_EXTRA add constraint FKInclusa
     foreign key (CodPrenotazione)
     references PRENOTAZIONI;

alter table SPESE_EXTRA add constraint FKFattura
     foreign key (CodBadge)
     references BADGE;

alter table TARIFFARI add constraint FKCostoTipologia
     foreign key (NomeTipologia)
     references TIPOLOGIE;

alter table TARIFFARI add constraint FKCostoNave
     foreign key (NomeNave)
     references NAVI;

alter table TARIFFARI_PRENOTAZIONI add constraint FKApp_PRE
     foreign key (CodPrenotazione)
     references PRENOTAZIONI;

alter table TARIFFARI_PRENOTAZIONI add constraint FKApp_TAR
     foreign key (CodTariffario)
     references TARIFFARI;

alter table TRATTE add constraint FKArrivo
     foreign key (CodPortoArrivo)
     references PORTI;

alter table TRATTE add constraint FKPartenza
     foreign key (CodPortoPartenza)
     references PORTI;

alter table TURNI_LAVORATIVI add constraint FKLavora
     foreign key (CodiceFiscale)
     references PERSONALE;


-- Index Section
-- _____________ 

