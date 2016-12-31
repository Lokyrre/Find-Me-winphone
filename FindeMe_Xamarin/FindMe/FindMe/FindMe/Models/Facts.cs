using System;
using System.Collections.Generic;

namespace FindMe.Models
{
    class Facts
    {
        private static List<String> uKnow = new List<String>
        {
            "La racine carrée de corde est ficelle.",
            
            "Bien que le sous-marin surpasse le bateau à quasiment tous points de vue, ce dernier représente plus de 97 % des voyages transaquatiques.",
            
            "Les téléphones portables ne donnent pas le cancer. Seulement l'hépatite.",
            
            "Le pantalon fut inventé au XVIe siècle pour éviter la colère de Poséidon. En effet, la vue de marins nus donne de l'urticaire au dieu de la mer.",

            "La masse atomique du germanium est de 72,64.",

            "89 % des tours de magie relèvent non de la magie, mais de la sorcellerie.",

            "L'œil d'une autruche est plus gros que son cerveau.",          

            "Dans la mythologie grecque, Dédale créa des ailes pour faire bisquer un groupe de minotaures.",        

            "Les humains peuvent survivre sous l'eau. Mais pas très longtemps.",

            "Reshep, dieu de la guerre cananéen, avait une gazelle qui lui poussait sur le front.",

            "Le pluriel de cheval est chevaux. Le pluriel de portail est un vin liquoreux de la péninsule ibérique.",
                        
            "Les ARN polymérases 1 permettent la synthèse de longs ARN ribosomiques.",
                        
            "Les rats sont incapables de vomir.",
                        
            "Un iguane peut rester sous l'eau pendant 28,7 minutes.",
                        
            "Le ver solitaire peut atteindre 23 m dans le corps humain.",
                        
            "Le paradoxe du chat de Schrödinger postule une situation dans laquelle un chat prisonnier à l'intérieur d'une boîte est à la fois mort et vivant. Schrödinger s'est servi de ce paradoxe pour pouvoir tuer des chats impunément.",
                        
            "Chaque centimètre carré de peau humaine comporte en moyenne 5 millions de bactéries.",
                        
            "Le Soleil est 330 330 fois plus grand que la Terre.",
                        
            "L'espérance de vie moyenne d'un rhinocéros en captivité est de 15 ans.",
                        
            "Les vulcanologues ont tous les oreilles pointues.",
                        
            "Les avocats sont les plus riches de tous les fruits.",
                        
            "Les avocats sont les plus riches de tous les fruits et de toutes les professions libérales.",
                        
            "La révolution de la Lune autour de la Terre dure 27,32 jours.",
                        
            "La milliardième décimale de Pi est 9.",
                        
            "Si vous avez du mal en calcul mental, il y a un moyen mnémotechnique tout simple : un plus deux plus 60 plus 12 moins six billions n'est pas égal à 504. Voilà. Vous pouvez maintenant effectuer facilement des opérations arithmétiques complexes de tête.",
                        
            "Un gallon d'eau pèse 3,78 kilos.",
                        
            "L'eau chaude gèle plus vite que l'eau froide.",
                        
            "Le miel ne se gâte pas.",
                        
            "A l'âge adulte, le corps humain contient 250 grammes de sel.",
                        
            "Une nanoseconde dure un milliardième de seconde.",
                        
            "Selon la légende germanique, le chariot céleste de Thor était tiré par deux boucs.",
                        
            "La Chine est le deuxième pays producteur de soja au monde.",
                        
            "Avec 3410 °C, le tungstène détient le record de température de fusion de tous les métaux.",
                        
            "En cas de mauvaise haleine, il est conseillé de se brosser doucement la langue deux fois par jour.",
                        
            "Le dentifrice romain était composé d'urine humaine. L'utilisation de cet ingrédient a perduré jusqu'au XVIIIe siècle.",
                        
            "Signé par Henri IV, l'édit de Nantes de 1598 reconnaît la liberté de culte aux protestants. Il est révoqué moins d'un siècle plus tard, en 1685.",
                        
            "Pi est le rapport entre la circonférence d'un cercle et son diamètre en géométrie euclidienne.",
                        
            "La guerre américano-mexicaine a pris fin en 1848 avec la signature du traité de Guadalupe Hidalgo.",
                       
            "C'est le Canadien Sandford Fleming qui, en 1879, a proposé le premier de diviser le monde en fuseaux horaires normalisés.",
                        
            "Marie Curie a découvert la théorie de la radioactivité, le traitement de la radioactivité et la mort par radioactivité.",
            
            "À la fin de La Mouette d'Anton Tchekhov, Konstantin se suicide.",
          
            "Contrairement aux idées reçues, les Inuits n'ont pas une centaine de mots pour dire « neige ». Ils ont en revanche 234 façons de dire « caramel ».",
            
            "Dans l'Angleterre victorienne, un roturier n'avait pas le droit de regarder la reine en face. En effet, on pensait à l'époque que les pauvres étaient capables de voler les pensées. Aujourd'hui, la science a prouvé que moins de 4 % des pauvres possèdent cette faculté",
            
            "Quand en 1862, Abraham Lincoln ratifia la Proclamation d'émancipation qui accordait la liberté aux esclaves, il était en état de somnambulisme et ne se souvenait de rien le matin suivant.",

            "En 1983, à la demande d'un enfant mourant, le grand cycliste Louison Bobet a mangé 75 galettes de blé noir avant de décéder d'une intoxication au blé noir.",

            "William Shakespeare n'a jamais existé. Ses pièces ont été créées en 1589 par Francis Bacon, qui s'est servi d'une planche de ouija pour asservir des esprits dramaturges.",

            "On affirme à tort que Thomas Edison a inventé le culturisme en 1878. En réalité, Nikola Tesla avait fait breveter cette activité trois ans plus tôt, sous le nom de « bobinisme ».",

            "Les baleines sont deux fois plus intelligentes et trois fois plus goûteuses que les humains.",

            "Il a fallu attendre 1895 pour que le frein automobile soit inventé. Jusque-là, le conducteur devait rester en permanence dans le véhicule et tourner en rond en attendant le retour de ses passagers.",

            "Edmund Hillary, premier homme à avoir gravi l'Everest, accomplit cet exploit par hasard en chassant un oiseau.",

            "Le carbone soumis à une pression intense produit du diamant. Le diamant soumis à une pression intense produit les particules en polystyrène servant à caler les colis.",

            "Le poisson le plus venimeux est l'hoplostèthe orange. Son corps entier, à l'exception des yeux, est constitué d'un poison mortel. Ses yeux sont composés d'un autre poison mortel moins violent.",

            "Le poste de bouffon fut inventé par accident, quand un vassal en pleine crise d'épilepsie déclencha l'hilarité générale.",

            "La comète de Halley est visible depuis la Terre tous les 76 ans. Les 75 autres années, elle hiberne tranquillement dans le noyau du Soleil.",

            "Le premier vol commercial a eu lieu en 1914. Tous les passagers ont hurlé du décollage à l'atterrissage.",

            "Dans la mythologie grecque, Prométhée a volé le feu aux dieux pour le donner aux hommes, mais il a gardé les bijoux pour lui.",

            "La personne qui a découvert que le lait est potable avait particulièrement soif.",

            "Avant l'invention de l'avion, pour voler, il fallait ingérer de grandes quantités d'hélium.",

            "Avant l'invention des œufs brouillés en 1912, le brunch traditionnel était constitué de poussins crus ou de cailloux brouillés.",

            "Dans les années 30, il était interdit d'avoir un lapin de compagnie. D'où une recrudescence de souris avec de fausses oreilles de lapin collées sur la tête.",

            "Un enfant sur six sera un jour ou l'autre kidnappé par un Néerlandais.",

            "Selon des algorithmes très évolués, le nom le plus classe du monde est Abitbol.",

            "Pour fabriquer une photocopieuse, il suffit de photocopier un miroir.",

            "C'est par les rêves que notre subconscient nous rappelle d'aller à l'école en slip et de faire tomber nos dents.",

            "C'est par les rêves que notre subconscient nous rappelle d'aller à l'école en slip et de faire tomber nos dents."
        };

        public static List<string> UKnow
        {
            get
            {
                return uKnow;
            }

            set
            {
                uKnow = value;
            }
        }
    }
}
