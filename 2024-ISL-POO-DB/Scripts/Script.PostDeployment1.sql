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
    ('bonjour', 'name' ,1),
    ('hello', 'name', 2),
    ('merci', 'name', 1),
    ('thank you', 'name', 2),
    ('au revoir', 'name', 1),
    ('bye', 'name', 2);
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