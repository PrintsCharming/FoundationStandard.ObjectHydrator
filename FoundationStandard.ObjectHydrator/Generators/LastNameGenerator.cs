﻿using System;
using System.Collections.Generic;
using FoundationStandard.ObjectHydrator.Interfaces;

namespace FoundationStandard.ObjectHydrator.Generators
{
    public class LastNameGenerator:IGenerator<string>
    {
        Random random;
        IList<string> lastnames = new List<string>();

        public LastNameGenerator()
        {
            random = RandomSingleton.Instance.Random;
            LoadNames();
        }

        public string Generate()
        {
            return lastnames[random.Next(0, lastnames.Count)];
        }

        private void LoadNames()
        {
            lastnames = new List<String> { 
                "Abbott",
                "Acevedo",
                "Acosta",
                "Adams",
                "Adkins",
                "Aguilar",
                "Aguirre",
                "Alexander",
                "Ali",
                "Allen",
                "Allison",
                "Alvarado",
                "Alvarez",
                "Andersen",
                "Anderson",
                "Andrade",
                "Andrews",
                "Anthony",
                "Archer",
                "Arellano",
                "Arias",
                "Armstrong",
                "Arnold",
                "Arroyo",
                "Ashley",
                "Atkins",
                "Atkinson",
                "Austin",
                "Avery",
                "Avila",
                "Ayala",
                "Ayers",
                "Bailey",
                "Baird",
                "Baker",
                "Baldwin",
                "Ball",
                "Ballard",
                "Banks",
                "Barajas",
                "Barber",
                "Barker",
                "Barnes",
                "Barnett",
                "Barr",
                "Barrera",
                "Barrett",
                "Barron",
                "Barry",
                "Bartlett",
                "Barton",
                "Bass",
                "Bates",
                "Bauer",
                "Bautista",
                "Baxter",
                "Bean",
                "Beard",
                "Beasley",
                "Beck",
                "Becker",
                "Bell",
                "Beltran",
                "Bender",
                "Benitez",
                "Benjamin",
                "Bennett",
                "Benson",
                "Bentley",
                "Benton",
                "Berg",
                "Berger",
                "Bernard",
                "Berry",
                "Best",
                "Bird",
                "Bishop",
                "Black",
                "Blackburn",
                "Blackwell",
                "Blair",
                "Blake",
                "Blanchard",
                "Blankenship",
                "Blevins",
                "Bolton",
                "Bond",
                "Bonilla",
                "Booker",
                "Boone",
                "Booth",
                "Bowen",
                "Bowers",
                "Bowman",
                "Boyd",
                "Boyer",
                "Boyle",
                "Bradford",
                "Bradley",
                "Bradshaw",
                "Brady",
                "Branch",
                "Brandt",
                "Braun",
                "Bray",
                "Brennan",
                "Brewer",
                "Bridges",
                "Briggs",
                "Bright",
                "Brock",
                "Brooks",
                "Brown",
                "Browning",
                "Bruce",
                "Bryan",
                "Bryant",
                "Buchanan",
                "Buck",
                "Buckley",
                "Bullock",
                "Burch",
                "Burgess",
                "Burke",
                "Burnett",
                "Burns",
                "Burton",
                "Bush",
                "Butler",
                "Byrd",
                "Cabrera",
                "Cain",
                "Calderon",
                "Caldwell",
                "Calhoun",
                "Callahan",
                "Camacho",
                "Cameron",
                "Campbell",
                "Campos",
                "Cannon",
                "Cantrell",
                "Cantu",
                "Cardenas",
                "Carey",
                "Carlson",
                "Carney",
                "Carpenter",
                "Carr",
                "Carrillo",
                "Carroll",
                "Carson",
                "Carter",
                "Case",
                "Casey",
                "Castaneda",
                "Castillo",
                "Castro",
                "Cervantes",
                "Chambers",
                "Chan",
                "Chandler",
                "Chaney",
                "Chang",
                "Chapman",
                "Charles",
                "Chase",
                "Chavez",
                "Chen",
                "Cherry",
                "Choi",
                "Christensen",
                "Christian",
                "Chung",
                "Church",
                "Cisneros",
                "Clark",
                "Clarke",
                "Clay",
                "Clayton",
                "Clements",
                "Cline",
                "Cobb",
                "Cochran",
                "Coffey",
                "Cohen",
                "Cole",
                "Coleman",
                "Collier",
                "Collins",
                "Colon",
                "Combs",
                "Compton",
                "Conley",
                "Conner",
                "Conrad",
                "Contreras",
                "Conway",
                "Cook",
                "Cooke",
                "Cooley",
                "Cooper",
                "Copeland",
                "Cordova",
                "Cortez",
                "Costa",
                "Cowan",
                "Cox",
                "Craig",
                "Crane",
                "Crawford",
                "Crosby",
                "Cross",
                "Cruz",
                "Cuevas",
                "Cummings",
                "Cunningham",
                "Curry",
                "Curtis",
                "Dalton",
                "Daniel",
                "Daniels",
                "Daugherty",
                "Davenport",
                "David",
                "Davidson",
                "Davies",
                "Davila",
                "Davis",
                "Dawson",
                "Day",
                "Dean",
                "Decker",
                "Delacruz",
                "Deleon",
                "Delgado",
                "Dennis",
                "Diaz",
                "Dickerson",
                "Dickson",
                "Dillon",
                "Dixon",
                "Dodson",
                "Dominguez",
                "Donaldson",
                "Donovan",
                "Dorsey",
                "Dougherty",
                "Douglas",
                "Downs",
                "Doyle",
                "Drake",
                "Duarte",
                "Dudley",
                "Duffy",
                "Duke",
                "Duncan",
                "Dunlap",
                "Dunn",
                "Duran",
                "Durham",
                "Dyer",
                "Eaton",
                "Edwards",
                "Elliott",
                "Ellis",
                "Ellison",
                "English",
                "Erickson",
                "Escobar",
                "Esparza",
                "Espinoza",
                "Estes",
                "Estrada",
                "Evans",
                "Everett",
                "Ewing",
                "Farley",
                "Farmer",
                "Farrell",
                "Faulkner",
                "Ferguson",
                "Fernandez",
                "Ferrell",
                "Fields",
                "Figueroa",
                "Finley",
                "Fischer",
                "Fisher",
                "Fitzgerald",
                "Fitzpatrick",
                "Fleming",
                "Fletcher",
                "Flores",
                "Flowers",
                "Floyd",
                "Flynn",
                "Foley",
                "Forbes",
                "Ford",
                "Foster",
                "Fowler",
                "Fox",
                "Francis",
                "Franco",
                "Frank",
                "Franklin",
                "Frazier",
                "Frederick",
                "Freeman",
                "French",
                "Frey",
                "Friedman",
                "Fritz",
                "Frost",
                "Fry",
                "Frye",
                "Fuentes",
                "Fuller",
                "Gaines",
                "Gallagher",
                "Gallegos",
                "Galloway",
                "Galvan",
                "Gamble",
                "Garcia",
                "Gardner",
                "Garner",
                "Garrett",
                "Garrison",
                "Garza",
                "Gates",
                "Gay",
                "Gentry",
                "George",
                "Gibbs",
                "Gibson",
                "Gilbert",
                "Giles",
                "Gill",
                "Gillespie",
                "Gilmore",
                "Glass",
                "Glenn",
                "Glover",
                "Golden",
                "Gomez",
                "Gonzales",
                "Gonzalez",
                "Good",
                "Goodman",
                "Goodwin",
                "Gordon",
                "Gould",
                "Graham",
                "Grant",
                "Graves",
                "Gray",
                "Green",
                "Greene",
                "Greer",
                "Gregory",
                "Griffin",
                "Griffith",
                "Grimes",
                "Gross",
                "Guerra",
                "Guerrero",
                "Gutierrez",
                "Guzman",
                "Haas",
                "Hahn",
                "Hale",
                "Haley",
                "Hall",
                "Hamilton",
                "Hammond",
                "Hampton",
                "Hancock",
                "Haney",
                "Hanna",
                "Hansen",
                "Hanson",
                "Hardin",
                "Harding",
                "Hardy",
                "Harmon",
                "Harper",
                "Harrell",
                "Harrington",
                "Harris",
                "Harrison",
                "Hart",
                "Hartman",
                "Harvey",
                "Hatfield",
                "Hawkins",
                "Hayden",
                "Hayes",
                "Haynes",
                "Hays",
                "Heath",
                "Hebert",
                "Henderson",
                "Hendricks",
                "Hendrix",
                "Henry",
                "Hensley",
                "Henson",
                "Herman",
                "Hernandez",
                "Herrera",
                "Herring",
                "Hess",
                "Hester",
                "Hickman",
                "Hicks",
                "Higgins",
                "Hill",
                "Hines",
                "Hinton",
                "Ho",
                "Hobbs",
                "Hodge",
                "Hodges",
                "Hoffman",
                "Hogan",
                "Holden",
                "Holder",
                "Holland",
                "Holloway",
                "Holmes",
                "Holt",
                "Hood",
                "Hooper",
                "Hoover",
                "Hopkins",
                "Horn",
                "Horne",
                "Horton",
                "House",
                "Houston",
                "Howard",
                "Howe",
                "Howell",
                "Huang",
                "Hubbard",
                "Huber",
                "Hudson",
                "Huerta",
                "Huff",
                "Huffman",
                "Hughes",
                "Hull",
                "Humphrey",
                "Hunt",
                "Hunter",
                "Hurley",
                "Hurst",
                "Hutchinson",
                "Huynh",
                "Ibarra",
                "Ingram",
                "Irwin",
                "Jackson",
                "Jacobs",
                "Jacobson",
                "James",
                "Jarvis",
                "Jefferson",
                "Jenkins",
                "Jennings",
                "Jensen",
                "Jimenez",
                "Johns",
                "Johnson",
                "Johnston",
                "Jones",
                "Jordan",
                "Joseph",
                "Joyce",
                "Juarez",
                "Kaiser",
                "Kane",
                "Kaufman",
                "Keith",
                "Keller",
                "Kelley",
                "Kelly",
                "Kemp",
                "Kennedy",
                "Kent",
                "Kerr",
                "Key",
                "Khan",
                "Kidd",
                "Kim",
                "King",
                "Kirby",
                "Kirk",
                "Klein",
                "Kline",
                "Knapp",
                "Knight",
                "Knox",
                "Koch",
                "Kramer",
                "Krause",
                "Krueger",
                "Lam",
                "Lamb",
                "Lambert",
                "Landry",
                "Lane",
                "Lang",
                "Lara",
                "Larsen",
                "Larson",
                "Lawrence",
                "Lawson",
                "Le",
                "Leach",
                "Leblanc",
                "Lee",
                "Leon",
                "Leonard",
                "Lester",
                "Levine",
                "Levy",
                "Lewis",
                "Li",
                "Lin",
                "Lindsey",
                "Little",
                "Liu",
                "Livingston",
                "Lloyd",
                "Logan",
                "Long",
                "Lopez",
                "Love",
                "Lowe",
                "Lowery",
                "Lozano",
                "Lucas",
                "Lucero",
                "Luna",
                "Lutz",
                "Lynch",
                "Lynn",
                "Lyons",
                "Macdonald",
                "Macias",
                "Mack",
                "Madden",
                "Maddox",
                "Mahoney",
                "Maldonado",
                "Malone",
                "Mann",
                "Manning",
                "Marks",
                "Marquez",
                "Marsh",
                "Marshall",
                "Martin",
                "Martinez",
                "Mason",
                "Massey",
                "Mata",
                "Mathews",
                "Mathis",
                "Matthews",
                "Maxwell",
                "May",
                "Mayer",
                "Maynard",
                "Mayo",
                "Mays",
                "Mcbride",
                "Mccall",
                "Mccann",
                "Mccarthy",
                "Mccarty",
                "Mcclain",
                "Mcclure",
                "Mcconnell",
                "Mccormick",
                "Mccoy",
                "Mccullough",
                "Mcdaniel",
                "Mcdonald",
                "Mcdowell",
                "Mcfarland",
                "Mcgee",
                "Mcgrath",
                "Mcguire",
                "Mcintosh",
                "Mcintyre",
                "Mckay",
                "Mckee",
                "Mckenzie",
                "Mckinney",
                "Mcknight",
                "Mclaughlin",
                "Mclean",
                "Mcmahon",
                "Mcmillan",
                "Mcneil",
                "Mcpherson",
                "Meadows",
                "Medina",
                "Mejia",
                "Melendez",
                "Melton",
                "Mendez",
                "Mendoza",
                "Mercado",
                "Mercer",
                "Merritt",
                "Meyer",
                "Meyers",
                "Meza",
                "Michael",
                "Middleton",
                "Miles",
                "Miller",
                "Mills",
                "Miranda",
                "Mitchell",
                "Molina",
                "Monroe",
                "Montes",
                "Montgomery",
                "Montoya",
                "Moody",
                "Moon",
                "Mooney",
                "Moore",
                "Mora",
                "Morales",
                "Moran",
                "Moreno",
                "Morgan",
                "Morris",
                "Morrison",
                "Morrow",
                "Morse",
                "Morton",
                "Moses",
                "Mosley",
                "Moss",
                "Moyer",
                "Mueller",
                "Mullen",
                "Mullins",
                "Munoz",
                "Murillo",
                "Murphy",
                "Murray",
                "Myers",
                "Nash",
                "Navarro",
                "Neal",
                "Nelson",
                "Newman",
                "Newton",
                "Nguyen",
                "Nichols",
                "Nicholson",
                "Nielsen",
                "Nixon",
                "Noble",
                "Nolan",
                "Norman",
                "Norris",
                "Norton",
                "Novak",
                "Nunez",
                "Obrien",
                "Ochoa",
                "Oconnell",
                "Oconnor",
                "Odom",
                "Odonnell",
                "Oliver",
                "Olsen",
                "Olson",
                "Oneal",
                "Oneill",
                "Orozco",
                "Orr",
                "Ortega",
                "Ortiz",
                "Osborn",
                "Osborne",
                "Owen",
                "Owens",
                "Pace",
                "Pacheco",
                "Padilla",
                "Page",
                "Palmer",
                "Park",
                "Parker",
                "Parks",
                "Parrish",
                "Parsons",
                "Patel",
                "Patrick",
                "Patterson",
                "Patton",
                "Paul",
                "Payne",
                "Pearson",
                "Peck",
                "Pena",
                "Pennington",
                "Perez",
                "Perkins",
                "Perry",
                "Peters",
                "Petersen",
                "Peterson",
                "Petty",
                "Pham",
                "Phelps",
                "Phillips",
                "Pierce",
                "Pineda",
                "Pittman",
                "Pitts",
                "Pollard",
                "Ponce",
                "Poole",
                "Pope",
                "Porter",
                "Potter",
                "Potts",
                "Powell",
                "Powers",
                "Pratt",
                "Preston",
                "Price",
                "Prince",
                "Proctor",
                "Pruitt",
                "Pugh",
                "Quinn",
                "Ramirez",
                "Ramos",
                "Ramsey",
                "Randall",
                "Randolph",
                "Rangel",
                "Rasmussen",
                "Ray",
                "Raymond",
                "Reed",
                "Reese",
                "Reeves",
                "Reid",
                "Reilly",
                "Reyes",
                "Reynolds",
                "Rhodes",
                "Rice",
                "Rich",
                "Richard",
                "Richards",
                "Richardson",
                "Richmond",
                "Riddle",
                "Riggs",
                "Riley",
                "Rios",
                "Ritter",
                "Rivas",
                "Rivera",
                "Rivers",
                "Roach",
                "Robbins",
                "Roberson",
                "Roberts",
                "Robertson",
                "Robinson",
                "Robles",
                "Rocha",
                "Rodgers",
                "Rodriguez",
                "Rogers",
                "Rojas",
                "Rollins",
                "Roman",
                "Romero",
                "Rosales",
                "Rosario",
                "Rose",
                "Ross",
                "Roth",
                "Rowe",
                "Rowland",
                "Roy",
                "Rubio",
                "Ruiz",
                "Rush",
                "Russell",
                "Russo",
                "Ryan",
                "Salas",
                "Salazar",
                "Salinas",
                "Sampson",
                "Sanchez",
                "Sanders",
                "Sandoval",
                "Sanford",
                "Santana",
                "Santiago",
                "Santos",
                "Saunders",
                "Savage",
                "Sawyer",
                "Schaefer",
                "Schmidt",
                "Schmitt",
                "Schneider",
                "Schroeder",
                "Schultz",
                "Schwartz",
                "Scott",
                "Sellers",
                "Serrano",
                "Sexton",
                "Shaffer",
                "Shah",
                "Shannon",
                "Sharp",
                "Shaw",
                "Shea",
                "Shelton",
                "Shepard",
                "Shepherd",
                "Sheppard",
                "Sherman",
                "Shields",
                "Short",
                "Silva",
                "Simmons",
                "Simon",
                "Simpson",
                "Sims",
                "Singh",
                "Singleton",
                "Skinner",
                "Sloan",
                "Small",
                "Smith",
                "Snow",
                "Snyder",
                "Solis",
                "Solomon",
                "Sosa",
                "Soto",
                "Sparks",
                "Spears",
                "Spence",
                "Spencer",
                "Stafford",
                "Stanley",
                "Stanton",
                "Stark",
                "Steele",
                "Stein",
                "Stephens",
                "Stephenson",
                "Stevens",
                "Stevenson",
                "Stewart",
                "Stokes",
                "Stone",
                "Stout",
                "Strickland",
                "Strong",
                "Stuart",
                "Suarez",
                "Sullivan",
                "Summers",
                "Sutton",
                "Swanson",
                "Sweeney",
                "Tanner",
                "Tapia",
                "Tate",
                "Taylor",
                "Terrell",
                "Terry",
                "Thomas",
                "Thompson",
                "Thornton",
                "Todd",
                "Torres",
                "Townsend",
                "Tran",
                "Travis",
                "Trevino",
                "Trujillo",
                "Tucker",
                "Turner",
                "Tyler",
                "Underwood",
                "Valdez",
                "Valencia",
                "Valentine",
                "Valenzuela",
                "Vance",
                "Vang",
                "Vargas",
                "Vasquez",
                "Vaughan",
                "Vaughn",
                "Vazquez",
                "Vega",
                "Velasquez",
                "Velazquez",
                "Velez",
                "Villa",
                "Villanueva",
                "Villarreal",
                "Villegas",
                "Vincent",
                "Wade",
                "Wagner",
                "Walker",
                "Wall",
                "Wallace",
                "Waller",
                "Walls",
                "Walsh",
                "Walter",
                "Walters",
                "Walton",
                "Wang",
                "Ward",
                "Ware",
                "Warner",
                "Warren",
                "Washington",
                "Waters",
                "Watkins",
                "Watson",
                "Watts",
                "Weaver",
                "Webb",
                "Weber",
                "Webster",
                "Weeks",
                "Weiss",
                "Welch",
                "Wells",
                "Werner",
                "West",
                "Wheeler",
                "Whitaker",
                "White",
                "Whitehead",
                "Whitney",
                "Wiggins",
                "Wilcox",
                "Wiley",
                "Wilkerson",
                "Wilkins",
                "Wilkinson",
                "Williams",
                "Williamson",
                "Willis",
                "Wilson",
                "Winters",
                "Wise",
                "Wolf",
                "Wolfe",
                "Wong",
                "Wood",
                "Woodard",
                "Woods",
                "Woodward",
                "Wright",
                "Wu",
                "Wyatt",
                "Yang",
                "Yates",
                "Yoder",
                "York",
                "Young",
                "Yu",
                "Zamora",
                "Zavala",
                "Zhang",
                "Zimmerman",
                "Zuniga"
            };
        }

    }
}
