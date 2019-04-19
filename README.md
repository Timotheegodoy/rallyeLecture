<h1>Rallye Lecture</h1>
Le but de cette activité est de creer un site internet sur lequel des élèves peuvent se connecter pour répondre à des quizz sur le/les livre(s) qu'ils ont lu. Cette partie de l'activité consiste à réaliser une application Windows Form en C# permettant à un professeur d'alimenter une base de données avec un fichier csv. Le fichier csv contient donc une liste d'élève (prénom et nom). Par la suite après avoir lancé le programme, des identifiants de connexion à notre site sont donc créées et sont enregistré dans un fichier csv afin de les distribués aux élèves.

Le projet est divisé en 3 grandes parties :

Lecture/ecriture des informations d'un fichier csv.
Ecriture d'un fichier csv avec les informations de connection de chaques eleves.
Alimentation d'une base de données.
Les outils mis en oeuvre :

* Visual Studio
* C#
* Windows Form
* bibliotèque de classe
* programmation objet

<h2>Cas d'utilisation</h2>

![cas.png](https://image.noelshack.com/fichiers/2019/16/5/1555661769-capture.png)<br>

<h2>Diagrammes de classe</h2>

![diagramme1.png](https://image.noelshack.com/fichiers/2019/16/5/1555661772-capture2.png)<br>

![diagramme2.png](https://image.noelshack.com/fichiers/2019/16/5/1555661774-capture3.png)<br>

<h2>Développement</h2>


Nous retrouvons donc une interfaces Windows Forms :

![capture.png](https://image.noelshack.com/fichiers/2019/15/3/1554852483-capture.png)<br>


<ul>
  <li>Choix du csv à utiliser</li>
  <li>Choix de l'année scolaire</li>
  <li>Choix du niveau scolaire</li>
  <li>Choix de la génération du mot de passe</li>
</ul>

* Exemple csv créer par le professeur

![avant.png](https://image.noelshack.com/fichiers/2019/16/5/1555667248-capture4.png)<br>

* Exemple csv générer par le programme

![apres.png](https://image.noelshack.com/fichiers/2019/16/5/1555667252-capture5.png)<br>

<br>
<h2>Base de données sql</h2>

![capture2.png](https://image.noelshack.com/fichiers/2019/15/3/1554853662-sans-titre.png)<br>
![capture3.png](https://image.noelshack.com/fichiers/2019/15/3/1554853750-capture2.png)<br>
