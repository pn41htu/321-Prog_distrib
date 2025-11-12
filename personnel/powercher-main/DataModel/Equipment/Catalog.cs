using System;
using System.Collections.Generic;

namespace DataModel
{
    public static class Catalog
    {
        public static List<ConsumingApplianceDescription> ConsumingAppliances = new()
        {
            // Cuisine
            new("Réfrigérateur combiné", 150, "Bosch", "KGN33", "Frigo à l'américaine avec unité de fabrication de glaçons", 1233, ApplianceCategory.Kitchen),
            new("Lave-vaisselle", 1800, "Siemens", "SN25", "Lave-vaisselle silencieux en inox", 899, ApplianceCategory.Kitchen),
            new("Plaque à induction", 7200, "Miele", "KM7201", "Plaque à induction 4 zones avec booster", 1390, ApplianceCategory.Kitchen),
            new("Four encastrable", 2500, "Samsung", "NV75K", "Four multifonctions avec nettoyage pyrolyse", 890, ApplianceCategory.Kitchen),
            new("Micro-ondes", 900, "Panasonic", "NN-GD37", "Four à micro-ondes grill 23L", 250, ApplianceCategory.Kitchen),
            new("Bouilloire électrique", 2000, "Philips", "HD9350", "Bouilloire inox 1.7L", 79, ApplianceCategory.Kitchen),
            new("Machine à café", 1450, "DeLonghi", "Magnifica S", "Machine à café à grains automatique", 650, ApplianceCategory.Kitchen),
            new("Grille-pain", 850, "Moulinex", "Soleil LT300", "Grille-pain 2 fentes", 45, ApplianceCategory.Kitchen),
            new("Mixeur plongeant", 700, "Braun", "MQ5235", "Mixeur 3 vitesses avec accessoires", 89, ApplianceCategory.Kitchen),

            // Entretien
            new("Aspirateur sans fil", 500, "Dyson", "V15", "Aspirateur balai sans fil avec filtre HEPA", 899, ApplianceCategory.Cleaning),
            new("Lave-linge", 2200, "LG", "F4WV7", "Lave-linge 9kg avec technologie AI DD", 1090, ApplianceCategory.Cleaning),
            new("Sèche-linge", 2500, "AEG", "T8DBE", "Sèche-linge à pompe à chaleur 8kg", 890, ApplianceCategory.Cleaning),
            new("Fer à repasser", 2400, "Philips", "PerfectCare", "Fer vapeur avec régulation automatique", 180, ApplianceCategory.Cleaning),

            // Informatique
            new("Ordinateur portable", 120, "Apple", "MacBook Air M3", "Ordinateur portable 13 pouces ultra-léger", 1590, ApplianceCategory.Computing),
            new("Ordinateur de bureau", 250, "HP", "Pavilion 590", "PC de bureau compact et silencieux", 890, ApplianceCategory.Computing),
            new("Écran LCD", 60, "Dell", "U2720Q", "Écran 27 pouces 4K UHD", 550, ApplianceCategory.Computing),
            new("Routeur WiFi", 25, "TP-Link", "Archer AX6000", "Routeur WiFi 6 double bande", 299, ApplianceCategory.Computing),
            new("Imprimante", 35, "Canon", "Pixma MG3650S", "Imprimante multifonction jet d'encre", 129, ApplianceCategory.Computing),

            // Divertissement
            new("Téléviseur OLED", 180, "LG", "C3", "Téléviseur OLED 55 pouces 4K HDR", 1790, ApplianceCategory.Entertainment),
            new("Console de jeu", 200, "Sony", "PlayStation 5", "Console de salon nouvelle génération", 649, ApplianceCategory.Entertainment),
            new("Enceinte Bluetooth", 30, "JBL", "Flip 6", "Enceinte portable étanche avec basse renforcée", 139, ApplianceCategory.Entertainment),
            new("Système Home Cinema", 350, "Yamaha", "RX-V6A", "Amplificateur 7.2 avec enceintes surround", 999, ApplianceCategory.Entertainment),

            // Autres
            new("Lampe de bureau LED", 10, "Xiaomi", "Mi Smart Desk Lamp", "Lampe connectée à intensité réglable", 59, ApplianceCategory.Other),
            new("Chargeur de téléphone", 20, "Anker", "PowerPort 3", "Chargeur rapide USB-C 65W", 39, ApplianceCategory.Other),
            new("Radiateur d’appoint", 1500, "Rowenta", "SO9420", "Chauffage soufflant céramique", 119, ApplianceCategory.Other),
            new("Ventilateur sur pied", 60, "Honeywell", "QuietSet", "Ventilateur oscillant silencieux", 89, ApplianceCategory.Other),

            // Heating
            new("Pompe à chaleur air/air 3.5 kW", 1200, "Daikin", "Perfera FTXM35R", "Pompe à chaleur réversible air/air pour chauffage et climatisation de pièces moyennes.", 2390, ApplianceCategory.Heating),
            new("Pompe à chaleur air/eau 8 kW", 2500, "Mitsubishi Electric", "Ecodan PUHZ-SW75VHA", "Système air/eau pour maisons individuelles, fonctionne jusqu’à -15°C extérieur.", 5400, ApplianceCategory.Heating),
            new("Pompe à chaleur géothermique 10 kW", 1800, "Nibe", "F1255-10", "Pompe à chaleur sol/eau à compresseur modulant, haute efficacité énergétique.", 9800, ApplianceCategory.Heating),
            new("Pompe à chaleur hybride gaz/électrique 12 kW", 2200, "Vaillant", "auroCOMPACT VSC 196/4-5", "Système combiné gaz et électricité avec gestion automatique selon la température.", 8900, ApplianceCategory.Heating),
            new("Pompe à chaleur piscine 9 kW", 1500, "Zodiac", "PowerForce 9", "Pompe à chaleur dédiée au chauffage de piscines jusqu’à 60 m³, fluide R32 écologique.", 3700, ApplianceCategory.Heating),
        };

        public static List<ProductiveApplianceDescription> ProductiveAppliances = new()
        {
            // Panneaux solaires
            new(name: "Panneau solaire 400 W monocristallin", power: 400, brand: "SunPower", model: "SPR-400", description: "Module monocristallin haut rendement, idéal pour toiture résidentielle.", price: 320, source: EnergySource.SUN),
            new(name: "Panneau solaire 450 W demi-cellules", power: 450, brand: "JA Solar", model: "JAM72S30-450", description: "Technologie demi-cellules pour de meilleures performances à haute température.", price: 270, source: EnergySource.SUN),
            new(name: "Panneau solaire 500 W bifacial", power: 500, brand: "LONGi", model: "LR5-72HBD-500", description: "Capte la lumière des deux côtés pour un rendement accru.", price: 340, source: EnergySource.SUN),
            new(name: "Panneau solaire 375 W verre/verre", power: 375, brand: "REC", model: "Alpha 375", description: "Construction verre/verre pour une durabilité supérieure et faible dégradation.", price: 295, source: EnergySource.SUN),

            // Éoliennes
            new(name: "Éolienne domestique 1 kW", power: 1000, brand: "Rutland", model: "1200", description: "Éolienne compacte pour sites ventés, usage autonome ou hybride PV.", price: 1800, source: EnergySource.WIND),
            new(name: "Éolienne domestique 3 kW", power: 3000, brand: "Hummer", model: "H3.1", description: "Générateur à aimants permanents, démarrage à faible vitesse de vent.", price: 5200, source: EnergySource.WIND),

            // Turbines hydrauliques (cours d’eau)
            new(name: "Turbine hydro 500 W pour ruisseau", power: 500, brand: "Powerspout", model: "PLT-500", description: "Turbine basse chute pour débits modestes, idéale micro-hydraulique.", price: 2200, source: EnergySource.WATER),
            new(name: "Turbine hydro 1.5 kW basse chute", power: 1500, brand: "Powerspout", model: "PLT-1500", description: "Solution micro-hydro fiable pour sites à faible hauteur de chute.", price: 3900, source: EnergySource.WATER),
            new(name: "Turbine hydro 2 kW haute chute", power: 2000, brand: "Powerspout", model: "PEL-2000", description: "Adaptée aux sites à forte hauteur de chute, rendement élevé.", price: 4600, source: EnergySource.WATER)
        };

        public static List<StorageDescription> Storages = new()
        {
            new("Supercondensateur", "Maxwell", "BCAP3000P","Module de supercondensateurs pour applications de pointe : forte puissance instantanée, plus d’un million de cycles.",3400, 0.5, 95),
            new("Batterie domestique 10 kWh", "Leclanché", "Powerwall 2","Batterie lithium-ion pour stockage résidentiel, intégration photovoltaïque, 90% de rendement.",9900, 10, 90),
            new("Batterie modulaire 5 kWh", "BYD", "Battery-Box Premium HVS 5.1","Module empilable lithium-fer-phosphate, compatible avec onduleurs hybrides.",5200, 5.1, 92),
            new("Batterie de secours 2.5 kWh portable", "EcoFlow", "Delta 2","Station d’énergie portable avec sorties AC/DC/USB, idéale secours et camping.",1600, 2.5, 88),
            new("Volant d’inertie 3 kWh", "Stornetic", "DuraStor-3","Stockage mécanique à grande vitesse, durée de vie >20 ans, usage industriel.",12000, 3, 85),
            new("Stockage air comprimé 50 kWh", "Hydrostor", "CompactAir-50","Système de stockage d’énergie par air comprimé, récupération thermique intégrée.",48000, 50, 70)
        };
    }
}
