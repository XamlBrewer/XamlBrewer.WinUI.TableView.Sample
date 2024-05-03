using Microsoft.UI;
using System.Collections.Generic;
using Windows.UI;

namespace XamlBrewer.WinUI.Models
{
    public class StandardModel
    {
        public static List<Particle> Particles =>
        [
            new Particle { Group = "fermion", Charge = "⅔", Mass = 2.2, Name = "up", Spin = "½", Symbol = "u", Type = "quark" },
            new Particle { Group = "fermion", Charge = "-⅓", Mass = 4.6, Name = "down", Spin = "½", Symbol = "d", Type = "quark" },
            new Particle { Group = "fermion", Charge = "⅔", Mass = 1_280.0, Name = "charm", Spin = "½", Symbol = "c", Type = "quark" },
            new Particle { Group = "fermion", Charge = "-⅓", Mass = 96.0, Name = "strange", Spin = "½", Symbol = "s", Type = "quark" },
            new Particle { Group = "fermion", Charge = "⅔", Mass = 173_100.0, Name = "top", Spin = "½", Symbol = "t", Type = "quark" },
            new Particle { Group = "fermion", Charge = "-⅓", Mass = 4_180.0, Name = "bottom", Spin = "½", Symbol = "b", Type = "quark" },
            new Particle { Group = "fermion", Charge = "-1", Mass = 0.511, Name = "electron", Spin = "½", Symbol = "e", Type = "lepton" },
            new Particle { Group = "fermion", Charge = "0", Mass = 0.0, Name= "electron neutrino", Spin = "½", Symbol = "νe", Type = "lepton" },
            new Particle { Group = "fermion", Charge = "-1", Mass = 105.7, Name = "muon", Spin = "½", Symbol = "μ", Type = "lepton" },
            new Particle { Group = "fermion", Charge = "0", Mass = 0.17, Name="muon neutrino", Spin="½", Symbol = "νμ", Type="lepton" },
            new Particle { Group = "fermion", Charge = "-1", Mass = 1_776.86, Name = "tau", Spin = "½", Symbol = "τ", Type = "lepton" },
            new Particle { Group = "fermion", Charge = "0", Mass = 15.5, Name="tau neutrino", Spin="½", Symbol = "ντ", Type="lepton" },
            new Particle { Group = "boson", Charge = "0", Mass = 0.0, Name = "photon", Spin = "1", Symbol = "γ", Type = "gauge boson" },
            new Particle { Group = "boson", Charge = "0", Mass = 0, Name = "gluon", Spin = "1", Symbol = "g", Type = "gauge boson" },
            new Particle { Group = "boson", Charge = "0", Mass = 91.19, Name = "Z boson", Spin = "1", Symbol = "Z", Type = "gauge boson" },
            new Particle { Group = "boson", Charge = "±1", Mass = 80.39, Name = "W boson", Spin = "1", Symbol = "W", Type = "gauge boson" },
            new Particle { Group = "boson", Charge = "0", Mass = 0.125, Name = "Higgs boson", Spin = "0", Symbol = "H", Type = "scalar boson" }
        ];

        public static List<string> Groups =>
        [
            "fermion",
            "boson"
        ];

        public static List<string> Types =>
        [
            "quark",
            "lepton",
            "gauge boson",
            "scalar boson"
        ];

        public static Color GetColor(string type)
        {
            return type switch
            {
                "quark" => Colors.MediumPurple,
                "lepton" => Colors.PaleGreen,
                "gauge boson" => Colors.Salmon,
                "scalar boson" => Colors.Khaki,
                _ => Colors.Transparent
            };
        }
    }
}
