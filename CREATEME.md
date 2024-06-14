# �tapes de cr�ation du projet vocabulaire pour le cours de POO
## Shéma général
DB > Repository + Mapping > Service > Presenter > View
## View
### 1. cr�ation du projet `application Windows Forms (.NET Framework)`
- nom du projet : `2024-ISL-POO-View`
- emplacement : `C:\CODE`
- Nom de la solution : `2024-ISL-POO`
- Infrastructure : `.NET Framework 4.7.2`
### 2. Fen�tre principale
1. renommer `Form1.cs` en `Home.cs`
2. mise en forme de la fen�tre gr�ce au `Design` (double-click sur `Home.cs`)
    1. drag-and-drop des �l�ments de la boite � outils sur la fen�tre
    2. modification des propri�t�s
## Domain
### 1. cr�ation du projet `Biblioth�que de classes (.NET Framework)`
- nom du projet : `2024-ISL-POO-Domain`
- emplacement : `C:\CODE\2024-ISL-POO`
- infrastructure : `.NET Framework 4.7.2`
> supprimer `Class1.cs` g�n�r�e automatiquement
### 2. classes models
1. ajouter un dossier `IModels`  � la racine du projet
    - ajouter les interfaces des classes `Models`
2. directement � la racine du projet, cr�er
    - les classes `Word`, `Language`, `Serie` sur base de leur interface
    - l'�num�ration `GrammaticalGroups`
## DAL (Data Access Layout)
### 1. cr�ation du projet `Biblioth�que de classes (.NET Framework)`
- nom du projet : `2024-ISL-POO-DAL`
- emplacement : `C:\CODE\2024-ISL-POO`
- infrastructure : `.NET Framework 4.7.2`
> supprimer `Class1.cs` g�n�r�e automatiquement
### 2. ADO
1. cr�er un dossier `ADO` � la racine du projet
2. cr�er une classe `Command` avec le code suivant:
```C#
public string CommandText { get; }

public Dictionary<string, object> Parameters { get; }

public bool IsStoreProcedure { get; }

public Command()
{
    IsStoreProcedure = false;
    Parameters = new Dictionary<string, object>();
}

public Command(string commandText, bool isStoreProcedure)
{
    CommandText = commandText;
    IsStoreProcedure = isStoreProcedure;
    Parameters = new Dictionary<string, object>();
}

public void AddParameter(string parameterName, object value)
{
    Parameters.Add(parameterName, value);
}
```
3. cr�er une classe `Connexion` avec le code suivant:
```C#
private DbProviderFactory _factory;
private string _connString;

// injection de d�pendance par constructeur
public Connexion(DbProviderFactory factory, string connString)
{
    _factory = factory;
    _connString = connString;
}

/// <summary>
/// � utilsier pour les INSERT
/// </summary>
/// <param name="command"></param>
/// <returns>le nombre de lignes affect�es</returns>
public int ExecuteNonQuery(Command command)
{
    using (DbConnection conn = CreateConnection())
    {
        using (DbCommand cmd = CreateCommand(conn, command))
        {
            conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}

public T ExecuteScalar<T>(Command command)
{
    using (DbConnection conn = CreateConnection())
    {
        using (DbCommand cmd = CreateCommand(conn, command))
        {
            conn.Open();
            return (T)cmd.ExecuteScalar();
        }
    }
}

public IEnumerable<T> ExecuteReader<T>(Command command, Func<DbDataReader, T> mapper)
{
    using (DbConnection conn = CreateConnection())
    {
        using (DbCommand cmd = CreateCommand(conn, command))
        {
            conn.Open();
            DbDataReader r = cmd.ExecuteReader();
            //List<T> result = new List<T>();
            while (r.Read())
            {
                // transformer DbDatareader -> T
                T t = mapper(r);
                //result.Add(t);
                yield return t;
            }
            //return result;
        }
    }
}

private DbCommand CreateCommand(DbConnection conn, Command command)
{
    DbCommand cmd = conn.CreateCommand();
    // quid ? de la query et des parametres
    cmd.CommandText = command.CommandText;
    foreach (KeyValuePair<string, object> item in command.Parameters)
    {
        DbParameter p = cmd.CreateParameter();
        p.ParameterName = item.Key;
        p.Value = item.Value ?? DBNull.Value;
        // direction ?
        cmd.Parameters.Add(p);
    }
    if (command.IsStoreProcedure)
    {
        cmd.CommandType = CommandType.StoredProcedure;
    }
    return cmd;
}
/// <summary>
/// cr�er une connection 
/// </summary>
private DbConnection CreateConnection()
{
    DbConnection c = _factory.CreateConnection();
    c.ConnectionString = _connString;
    return c;
}
```
### 3. Repositories
1. cr�er un dossier `Repositories` � la racine du projet
2. cr�er un dossier `Bases` dans le dossier `Repositories`
3. cr�er une classe abstraite `RepositoryBase` avec le code suivant:
```C#
private string sourceDB = "Data Source=***;" + // remplacer *** par l'adresse du serveur
    "Initial Catalog=***;" + // remplacer *** par le nom de la base de donn�es
    "Integrated Security=True;" +
    "Connect Timeout=60;" +
    "Encrypt=False;" +
    "TrustServerCertificate=False;" +
    "ApplicationIntent=ReadWrite;" +
    "MultiSubnetFailover=False";

protected readonly Connexion connect;//Classe cr��e pr�c�demment dans le dossier ADO

public RepositoryBase()
{
    connect = new Connexion(SqlClientFactory.Instance, sourceDB);
}
```
## Database
### 1. cr�ation du projet `Projet de base de donn�es SQL Server`
- nom du projet : `2024-ISL-POO-DB`
- emplacement : `C:\CODE\2024-ISL-POO`
### 2. tables
1. cr�er un dossier `Tables` � la racine du projet
2. cr�er un �l�ment `table` dans le dossier `Tables` et cr�er les structures de table (1 table = 1 fichier)
### 3. Scripts
1. cr�er un dossier `Scripts` � la racine du projet
2. cr�er un �l�ment de type `Script de post-d�ploiement` (garder le nom fournit automatiquement)
3. �crire les requ�tes de post-d�ployement dans ce script (premi�res don�nes a encoder ect...)
> il ne peut exister qu'un seul fichier de post-d�ployement
### 4. d�ployement
1. clic-droit sur le projet > `Publier...`
- choisir la base de donn�e cible (locale)
    - tester la connexion
- nommer la base de donn�es : `2024-ISL-POO-Vocabulaire`
- `Enregistrer le profil sous...` 
> cette �tape facilitera les mises � jour ult�rieure le cas �ch�ant
- `Publier`
### 5. liens entre DB et DAL
- r�cup�rer la chaine de connexion via l'`Explorateur d'objets SQL Server` > `Propri�t�s`
- mettre cette chaine de connexion dans le projet `DAL`, dans le fichier `RepositoryBase.cs`. (remplacer toute la `sourceDB` puis remettre en forme)
## Faire le point
D�sormais, tous les projets sont cr��s dans la solution.
Les couches sont :
1. `View` : interface utilisateur
2. `Domain` : donn�es sous forme objet
3. `DAL` ou `Data Access Layout` : couche d'acc�s aux donn�es
4. `DB` ou `Database` : couche de stockage des donn�es ADO
# Mise en place des fonctionnalités
- [X] liste des langues DB > View
- [X] liste (+ nombre) des mots DB > View
    - [X] nombre
    - [X] traductions
    - [X] grammatical group doit être correct
- [X] appliquer les filtres sur la liste de mots
    - [X] langue 1
    - [X] langue 2
    - [X] grammatical group
- [_] add mot View > DB
    - [_] gestion des doublons
- [_] lancer un test sur la liste des mots filtrée
- [_] créer les stats générales
    - [_] maj via tests
    - [_] afficher panel
    - [_] appliquer les filtres
- [_] serie
    - [_] ajouter
    - [_] ajouter un mot a une série
    - [_] ajouter des mots à une série
    - [_] filtrer selon série
- [_] ajouter langue