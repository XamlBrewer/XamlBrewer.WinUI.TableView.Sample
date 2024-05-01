using System.Collections.Generic;

namespace XamlBrewer.WinUI.Models
{
    public class StandardModel
    {
        public static List<Particle> Particles =>
        [
            new Particle { Class = "Fermion", Charge = -1.0 / 3.0, Mass = 0.0, Name = "Down", Spin = "1/2", Symbol = "d", Type = "Quark" },
            new Particle { Class = "Fermion", Charge = 2.0 / 3.0, Mass = 0.0, Name = "Up", Spin = "1/2", Symbol = "u", Type = "Quark" },
            new Particle { Class = "Fermion", Charge = -1.0, Mass = 0.511, Name = "Electron", Spin = "1/2", Symbol = "e", Type = "Lepton" },
            new Particle { Class = "Fermion", Charge = 0.0, Mass = 105.7, Name = "Muon", Spin = "1/2", Symbol = "μ", Type = "Lepton" },
            new Particle { Class = "Fermion", Charge = 0.0, Mass = 1_776.9, Name = "Tau", Spin = "1/2", Symbol = "τ", Type = "Lepton" },
            new Particle { Class = "Boson", Charge = 0.0, Mass = 0.0, Name = "Photon", Spin = "1", Symbol = "γ", Type = "Force Carrier" },
            new Particle { Class = "Boson", Charge = 0.0, Mass = 91.2, Name = "Z", Spin = "1", Symbol = "Z", Type = "Force Carrier" },
            new Particle { Class = "Boson", Charge = 0.0, Mass = 80.4, Name = "W", Spin = "1", Symbol = "W", Type = "Force Carrier" },
            new Particle { Class = "Boson", Charge = 0.0, Mass = 125.1, Name = "Higgs", Spin = "0", Symbol = "H", Type = "Scalar" }
        ];
    }
}
