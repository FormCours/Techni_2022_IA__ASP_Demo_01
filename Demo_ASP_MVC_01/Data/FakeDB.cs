using Demo_ASP_MVC_01.Models;
using System.Collections;
using System.Collections.Immutable;

namespace Demo_ASP_MVC_01.Data
{
    // Fausse base de donnée pour la demo =) 
    public static class FakeDB
    {
        private static IList<Personnage> _Personnages = new List<Personnage>
        {
            new Personnage() { Id = 1, Prenom = "Della", Nom = "Duck"},
            new Personnage() { Id = 2, Prenom = "Zaza", Nom = "Vanderquack"},
            new Personnage() { Id = 3, Prenom = "Balthazar", Nom = "Picsou"},
            new Personnage() { Id = 4, Prenom = "Riri", Nom = "Duck"}
        };
        private static int _LastId = 4;

        public static IEnumerable<Personnage> GetPersonnages()
        {
            return _Personnages.ToImmutableList();
        }

        public static int AjouterPersonnage(Personnage personnage)
        {
            _LastId++;
            _Personnages.Add(new Personnage()
            {
                Id = _LastId,
                Prenom = personnage.Prenom,
                Nom = personnage.Nom
            });
            return _LastId;
        }

    }
}
