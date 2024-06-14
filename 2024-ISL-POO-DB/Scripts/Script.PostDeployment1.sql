/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
set identity_insert languages on;
insert into languages(id, name) values
    (1, 'français'), 
    (2, 'anglais');
set identity_insert languages off;

insert into words(name, grammatical_group, id_language) values
    ('bonjour', 'nom' ,1),
    ('hello', 'nom', 2),
    ('merci', 'nom', 1),
    ('thank you', 'nom', 2),
    ('au revoir', 'nom', 1),
    ('bye', 'nom', 2);
insert into word_word values
    (1,2),
    (3,4),
    (5,6);

insert into series(name) values('politesse');
insert into serie_word(id_serie, id_word) values
    (1,1),
    (1,2),
    (1,3),
    (1,4),
    (1,5),
    (1,6);