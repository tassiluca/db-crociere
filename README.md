# Db-Crociere
Gestionale per una compagnia di crociere.

## Generazione DB
Per la generazione della struttura del database è necessario utilizzare il file er/ddl-dbCrociere.sql che contiene le ddl relative alla base dati.

## Esecuzione dell'Applicazione
Nella cartella Release modificare all'interno di db-crociere.exe.config la stringa di connessione al proprio server SQL locale:

	<connectionStrings>
		<add name="db_crociere.Properties.Settings.dbCrociereConnectionString1"
		     connectionString="Data Source=<your-server-name>;Initial Catalog=dbCrociere;Integrated Security=True"
		     providerName="System.Data.SqlClient" />
	</connectionStrings>

A questo punto basterà eseguire l'eseguibile db-crociere.exe.

## Ulteriori note
Nella cartella db-crociere sono contenuti i sorgenti dell'app.
