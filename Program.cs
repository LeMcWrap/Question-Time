using System;
using System.Collections.Generic;

class Program
{
    // Classe pour représenter une question
    class Question
    {
        public string Text { get; set; }
        public List<string> Choices { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string text, List<string> choices, int correctAnswerIndex)
        {
            Text = text;
            Choices = choices;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }

    static void Main(string[] args)
    {
        // Liste des questions du quiz
        List<Question> questions = new List<Question>
        {
            new Question( // question 1
                "N°1 : Quelle est la capitale de la France ?",
                new List<string> { "Londres", "Berlin", "Paris", "Madrid" },
                2 // Réponse correcte : C) Paris
            ),
            new Question( // question 2
                "N°2 : Combien de continents existe-t-il ?",
                new List<string> { "5", "6", "7", "8" },
                2 // Réponse correcte : C) 7
            ),
            new Question( // question 3
                "N°3 : Quelle est la plus grande planète du système solaire ?",
                new List<string> { "La Terre", "Jupiter", "Mars", "Saturne" },
                1 // Réponse correcte : B) Jupiter
            ),
            new Question( // question 4
                "N°4 : Qui a écrit \"Les Misérables\" ?",
                new List<string> { "Emile Zola", "Guillaume Musso", "Vyctor ugo", "Victor Hugo" },
                3 // Réponse correcte : D) Victor Hugo  
            ),
            new Question( // question 5
                "N°5 : Quel est le plus long fleuve du monde ?",
                new List<string> { "Amazone", "Nil", "Yangtsé", "Mississippi" },
                0 // Réponse correcte : A) Amazone
            ),
            new Question( // question 6
                "N°6 : Quelle est la langue la plus parlée dans le monde ?",
                new List<string> { "Anglais", "Mandarin", "Espagnol", "Arabe" },
                1 // Réponse correcte : B) Mandarin
            ),
            new Question( // question 7
                "N°7 : Quel est l'organe principal de la circulation sanguine ?",
                new List<string> { "Coeur", "Poumon", "Foie", "Rein" },
                0 // Réponse correcte : A) Cœur
            ),
            new Question( // question 8
                "N°8 : Qui a peint la Mona Lisa ?",
                new List<string> { "Vincent van Gogh", "Pablo Picasso", "Léonard de Vinci", "Claude Monet" },
                2 // Réponse correcte : C) Léonard de Vinci
            ),
            new Question( // question 9
                "N°9 : Quelle est la plus grande mer du monde ?",
                new List<string> { "Mer Méditerranée", "Mer des Caraïbes", "Mer Rouge", "Mer de Chine" },
                3 // Réponse correcte : D) Mer de Chine
            ),
            new Question( // question 10
                "N°10 : Qui a découvert l'Amérique ?",
                new List<string> { "Ferdinand Magellan", "Christophe Colomb", "Vasco de Gama", "Hernán Cortés" },
                1 // Réponse correcte : B) Christophe Colomb
            ),
            new Question( // question 11
                "N°11 : Quel est le pays le plus peuplé du monde ?",
                new List<string> { "Inde", "États-Unis", "Chine", "Indonésie" },
                2 // Réponse correcte : C) Chine
            ),
            new Question( // question 12
                "N°12 : Quel est l'élément chimique dont le symbole est O ?",
                new List<string> { "Or", "Oxygène", "Osmium", "Oganesson" },
                1 // Réponse correcte : B) Oxygène
            ),
            new Question( // question 13
                "N°13 : Quel est le plus grand océan du monde ?",
                new List<string> { "Océan Atlantique", "Océan Indien", "Océan Pacifique", "Océan Arctique" },
                2 // Réponse correcte : C) Océan Pacifique
            ),
            new Question( // question 14
                "N°14 : Quel est le plus grand désert du monde ?",
                new List<string> { "Désert du Sahara", "Désert de Gobi", "Désert d'Atacama", "Désert de Kalahari" },
                0 // Réponse correcte : A) Désert du Sahara
            ),
            new Question( // question 15
                "N°15 : Qui a écrit \"Roméo et Juliette\" ?",
                new List<string> { "Victor Hugo", "William Shakespeare", "Charles Dickens", "Molière" },
                1 // Réponse correcte : B) William Shakespeare
            ),
            new Question( // question 16
                "N°16 : Quelle est la monnaie utilisée au Japon ?",
                new List<string> { "Yuan", "Dollar", "Yen", "Won" },
                2 // Réponse correcte : C) Yen
            ),
            new Question( // question 17
                "N°17 : Quel est le plus long mur du monde ?",
                new List<string> { "Mur de Berlin", "Mur de Chine", "Mur d'Hadrien", "Mur de la Paix" },
                1 // Réponse correcte : B) Mur de Chine
            ),
            new Question( // question 18
                "N°18 : Quel est le pays d'origine du kangourou ?",
                new List<string> { "Australie", "Nouvelle-Zélande", "Afrique du Sud", "Brésil" },
                0 // Réponse correcte : A) Australie
            ),
            new Question( // question 19
                "N°19 : Quel est le nom de la première femme à avoir obtenu le prix Nobel ?",
                new List<string> { "Marie Curie", "Rosalind Franklin", "Ada Lovelace", "Jane Goodall" },
                0 // Réponse correcte : A) Marie Curie
            ),
            new Question( // question 20
                "N°20 : Quel est le plus grand animal terrestre ?",
                new List<string> { "Éléphant", "Girafe", "Rhinocéros", "Hippopotame" },
                0 // Réponse correcte : A) Éléphant
            ),
            new Question( // question 21
                "N°21 : Quel est le plus grand mammifère marin ?",
                new List<string> { "Orque", "Dauphin", "Baleine bleue", "Requin" },
                2 // Réponse correcte : C) Baleine bleue
            ),
            new Question( // question 22
                "N°22 : Quel est le nom de la capitale de l'Italie ?",
                new List<string> { "Rome", "Milan", "Venise", "Florence" },
                0 // Réponse correcte : A) Rome
            ),
            new Question( // question 23
                "N°23 : Qui a peint \"La Nuit étoilée\" ?",
                new List<string> { "Claude Monet", "Vincent van Gogh", "Pablo Picasso", "Henri Matisse" },
                1 // Réponse correcte : B) Vincent van Gogh
            ),
            new Question( // question 24
                "N°24 : Quel est le symbole chimique de l'eau ?",
                new List<string> { "H2O", "O2", "CO2", "NaCl" },
                0 // Réponse correcte : A) H2O
            ),
            new Question( // question 25
                "N°25 : Quel est le pays le plus vaste du monde ?",
                new List<string> { "Canada", "Chine", "Russie", "États-Unis" },
                2 // Réponse correcte : C) Russie
            ),
            new Question( // question 26
                "N°26 : Quel est le nom du célèbre détective créé par Arthur Conan Doyle ?",
                new List<string> { "Hercule Poirot", "Sherlock Holmes", "Miss Marple", "Philip Marlowe" },
                1 // Réponse correcte : B) Sherlock Holmes
            ),
            new Question( // question 27
                "N°27 : Qui a été le premier homme sur la Lune ?",
                new List<string> { "Buzz Aldrin", "Neil Armstrong", "Yuri Gagarin", "John Glenn" },
                1 // Réponse correcte : B) Neil Armstrong
            ),
            new Question( // question 28
                "N°28 : Quel est le nom de la première station spatiale ?",
                new List<string> { "Mir", "ISS", "Skylab", "Salyut" },
                2 // Réponse correcte : C) Skylab
            ),
            new Question( // question 29
                "N°29 : Quel est le nom du fleuve qui traverse Paris ?",
                new List<string> { "Seine", "Loire", "Rhin", "Garonne" },
                0 // Réponse correcte : A) Seine
            ),
            new Question( // question 30
                "N°30 : Quel est le nom de l'organe responsable de la production d'insuline ?",
                new List<string> { "Foie", "Pancréas", "Rein", "Cœur" },
                1 // Réponse correcte : B) Pancréas
            )
        };

        int score = 0;

        Console.WriteLine("Bienvenue à Question Time !");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Il n'y a qu'une seule et unique regle : \n" +
        "Il n'est possible de renter qu'un seul chiffre, aucune lettre.Exemple Question 1 ? Réponse : 1");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Il y a 30 questions alors bonne chance !\nRépondez aux questions suivantes :\n");

        // Parcourir chaque question
        foreach (var question in questions)
        {
            Console.WriteLine(question.Text);

            // Afficher les choix de réponse
            for (int i = 0; i < question.Choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {question.Choices[i]}");
            }

            // Obtenir la réponse de l'utilisateur
            Console.Write("\nVotre réponse : ");
            int userChoice = int.Parse(Console.ReadLine()) - 1;

            // Vérifier si la réponse est correcte
            if (userChoice == question.CorrectAnswerIndex)
            {
                Console.WriteLine("Bonne réponse !");
                score++;
            }
            else
            {
                Console.WriteLine($"Mauvaise réponse. La bonne réponse était : {question.Choices[question.CorrectAnswerIndex]}");
            }

            Console.WriteLine(); // Ligne vide pour la lisibilité
        }

        // Afficher le score final
        Console.WriteLine($"Votre score final : {score}/{questions.Count}");

        // Ajouter cette ligne pour empêcher la fermeture automatique
        Console.WriteLine("\n\n\n Appuyez sur une touche pour fermer...");
        Console.ReadKey(); // Attend que l'utilisateur appuie sur une touche
    }
}
