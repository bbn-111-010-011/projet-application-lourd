-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 03 juin 2025 à 01:48
-- Version du serveur : 5.7.40
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `stages`
--

-- --------------------------------------------------------

--
-- Structure de la table `annee`
--

DROP TABLE IF EXISTS `annee`;
CREATE TABLE IF NOT EXISTS `annee` (
  `annee` date NOT NULL,
  PRIMARY KEY (`annee`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `annee`
--

INSERT INTO `annee` (`annee`) VALUES
('2020-09-01'),
('2021-09-01'),
('2022-09-01'),
('2023-09-01');

-- --------------------------------------------------------

--
-- Structure de la table `classe_eleve`
--

DROP TABLE IF EXISTS `classe_eleve`;
CREATE TABLE IF NOT EXISTS `classe_eleve` (
  `code_classe` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `libellé_classe` varchar(25) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`code_classe`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `classe_eleve`
--

INSERT INTO `classe_eleve` (`code_classe`, `libellé_classe`) VALUES
('SSI', 'Sciences Informatiques'),
('SSL', 'Sciences de la Santé');

-- --------------------------------------------------------

--
-- Structure de la table `eleve`
--

DROP TABLE IF EXISTS `eleve`;
CREATE TABLE IF NOT EXISTS `eleve` (
  `numero_eleve` varchar(4) COLLATE utf8_unicode_ci NOT NULL,
  `nom_eleve_` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prenom_eleve` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `date_naissance` date DEFAULT NULL,
  `rue_eleve` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `libel_ville` varchar(25) COLLATE utf8_unicode_ci DEFAULT NULL,
  `cde_ville` int(11) DEFAULT NULL,
  `numero_option` varchar(3) COLLATE utf8_unicode_ci DEFAULT NULL,
  `code_classe` varchar(5) COLLATE utf8_unicode_ci DEFAULT NULL,
  `tel_eleve` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `mail_eleve` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `foyer_eleve` int(5) DEFAULT NULL,
  PRIMARY KEY (`numero_eleve`),
  KEY `cde_ville` (`cde_ville`),
  KEY `numero_option` (`numero_option`),
  KEY `code_classe` (`code_classe`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `eleve`
--

INSERT INTO `eleve` (`numero_eleve`, `nom_eleve_`, `prenom_eleve`, `date_naissance`, `rue_eleve`, `libel_ville`, `cde_ville`, `numero_option`, `code_classe`, `tel_eleve`, `mail_eleve`, `foyer_eleve`) VALUES
('E001', 'COULANGE', 'MATTEO', '2004-01-15', '1 rue Générée', 'Marseille', 13055, 'O01', 'SSL', '0', 'matteo.coulange@gmail.com', 0),
('E002', 'DELPORTO', 'Lorina', '2004-02-20', '15 Rue de Rivoli', 'Paris', 75056, 'O01', 'SSI', '0', 'lorina.delporto@gmail.com', 0),
('E003', 'Marsel', 'Ghozlne', '2004-03-12', '32 Avenue Jean Jaurès', 'Lyon', 69385, 'O01', 'SSL', '0', 'ghozlne.marsel@gmail.com', 0),
('E004', 'AZZI', 'Akram', '2004-04-05', '8 Place de la Bourse', 'Bordeaux', 33063, 'O01', 'SSI', '0', 'akram.azzi@gmail.com', 0),
('E005', 'BANDIERA', 'GIANNI', '2004-05-18', '12 Promenade des Anglais', 'Nice', 6088, 'O01', 'SSL', '0', 'gianni.bandiera@gmail.com', 0),
('E006', 'BOURI', 'Houssam', '2004-06-22', '23 Rue du Taur', 'Toulouse', 31555, 'O01', 'SSI', '0', 'houssam.bouri@gmail.com', 0),
('E007', 'CORDOVANA', 'Lucas', '2004-07-10', '14 Quai de la Fosse', 'Nantes', 44109, 'O01', 'SSL', '0', 'lucas.cordovana@gmail.com', 0),
('E008', 'DEBABO', 'Célia', '2004-08-01', '7 Rue du Dôme', 'Strasbourg', 67482, 'O01', 'SSI', '0', 'célia.debabo@gmail.com', 0),
('E009', 'MSA', 'ELMIRA', '2004-09-30', '25 Rue de l\'Université', 'Montpellier', 34172, 'O01', 'SSL', '0', 'elmira.msa@gmail.com', 0),
('E010', 'MADANI', 'Mouad', '2004-10-25', '10 Rue Faidherbe', 'Lille', 59350, 'O01', 'SSI', '0', 'mouad.madani@gmail.com', 0),
('E011', 'MEDMONE', 'Nadra', '2004-11-05', '9 Rue Saint-Michel', 'Rennes', 35238, 'O01', 'SSL', '0', 'nadra.medmone@gmail.com', 0),
('E012', 'MOKAREM', 'Mohamed Fodhel', '2004-12-19', '33 Cours Jean Jaurès', 'Grenoble', 38185, 'O01', 'SSI', '0', 'mohamedfodhel.mokarem@gmail.com', 0),
('E013', 'MOLLET', 'Oreyanne', '2005-01-03', '18 Rue Jeanne d\'Arc', 'Rouen', 76540, 'O01', 'SSL', '0', 'oreyanne.mollet@gmail.com', 0),
('E014', 'NGANDU-MUAMBA', 'Djelissa', '2005-02-14', '20 Cours Mirabeau', 'Aix-en-Provence', 13001, 'O01', 'SSI', '0', 'djelissa.ngandu-muamba@gmail.com', 0),
('E015', 'LAKDAR EZZINE', 'MOHAMED ABDEL', '2005-03-30', '5 Rue de la Liberté', 'Dijon', 21231, 'O01', 'SSL', '0', 'mohamedabdel.lakdarezzine@gmail.com', 0),
('E016', 'GIRARD', 'EMILIE', '2005-04-11', '11 Boulevard Foch', 'Angers', 49007, 'O01', 'SSI', '0', 'emilie.girard@gmail.com', 0),
('E017', 'ALI', 'MOUDJAHIDI', '2005-05-09', '3 Rue des Gras', 'Clermont-Ferrand', 63113, 'O01', 'SSL', '0', 'moudjahidi.ali@gmail.com', 0),
('E018', 'ABDELLI', 'ELYAS', '2005-06-20', '27 Rue Haute-Vienne', 'Limoges', 87085, 'O01', 'SSI', '0', 'elyas.abdelli@gmail.com', 0),
('E021', 'KAHLA', 'Iliasse', '2005-07-15', NULL, 'Marseille', 13055, NULL, NULL, '789643512', 'iliasse@gmail.com', 5),
('E022', 'BOUABID', 'Adli', '2005-08-28', '25 Rue Lautard', 'Vitrolles', 13127, NULL, NULL, '627898486', 'adli@gmail.com', 3),
('E023', 'BOUCHENTOUF', 'Nassim', '2005-09-07', '33  rue de la capelette', 'Roquevaire', 13360, NULL, NULL, '656452312', 'nasim@gmail.com', 8),
('E024', 'Lakhfif', 'Momo', '2005-10-16', '45 rue Maupassant', 'Pélissanne', 13330, NULL, NULL, '789785634', 'momo@gmail.com', 6);

-- --------------------------------------------------------

--
-- Structure de la table `enseigne`
--

DROP TABLE IF EXISTS `enseigne`;
CREATE TABLE IF NOT EXISTS `enseigne` (
  `numero_professeur` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `numero_matiere` varchar(9) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`numero_professeur`,`numero_matiere`),
  KEY `numero_matiere` (`numero_matiere`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `enseigne`
--

INSERT INTO `enseigne` (`numero_professeur`, `numero_matiere`) VALUES
('1', '1'),
('2', '2'),
('3', '3'),
('4', '4'),
('5', '5'),
('6', '6'),
('7', '6'),
('8', '7'),
('9', '8');

-- --------------------------------------------------------

--
-- Structure de la table `matiere_scolaire`
--

DROP TABLE IF EXISTS `matiere_scolaire`;
CREATE TABLE IF NOT EXISTS `matiere_scolaire` (
  `numero_matiere` varchar(9) COLLATE utf8_unicode_ci NOT NULL,
  `nom_matiere` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`numero_matiere`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `matiere_scolaire`
--

INSERT INTO `matiere_scolaire` (`numero_matiere`, `nom_matiere`) VALUES
('1', 'MATH'),
('2', 'FRANCAIS'),
('3', 'ANGLAIS'),
('4', 'CEJM'),
('5', 'INFO'),
('6', 'CERTIF'),
('7', 'PORTFOLIO'),
('8', 'ESPAGNOL');

-- --------------------------------------------------------

--
-- Structure de la table `option_bts`
--

DROP TABLE IF EXISTS `option_bts`;
CREATE TABLE IF NOT EXISTS `option_bts` (
  `numero_option` varchar(3) COLLATE utf8_unicode_ci NOT NULL,
  `code_option` varchar(5) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`numero_option`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `option_bts`
--

INSERT INTO `option_bts` (`numero_option`, `code_option`) VALUES
('O01', 'MKT'),
('O02', 'COM'),
('O03', 'INFO'),
('O04', 'GEST'),
('O05', 'RH'),
('O06', 'FIN'),
('O07', 'INT'),
('O08', 'ENV');

-- --------------------------------------------------------

--
-- Structure de la table `professeur`
--

DROP TABLE IF EXISTS `professeur`;
CREATE TABLE IF NOT EXISTS `professeur` (
  `numero_professeur` int(5) NOT NULL AUTO_INCREMENT,
  `nom_professeur` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `mdpass` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `code_professeur` varchar(2) COLLATE utf8_unicode_ci DEFAULT NULL,
  `chemin_img` varchar(256) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telephone_professeur` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `mail_professeur` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prenom_professeur` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `cde_ville` int(11) NOT NULL,
  `libel_ville` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`numero_professeur`),
  KEY `cde_ville` (`cde_ville`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `professeur`
--

INSERT INTO `professeur` (`numero_professeur`, `nom_professeur`, `mdpass`, `code_professeur`, `chemin_img`, `telephone_professeur`, `mail_professeur`, `prenom_professeur`, `cde_ville`, `libel_ville`) VALUES
(1, 'Bruno', 'mbruno', '1', 'bruno.jpg', '0658531724', 'bruno.paul@gmail.com', 'Paul', 1300, 'Marseille'),
(2, 'Casta', 'mcasta', '2', 'casta.jpg', '0698195980', 'casta.joelle@gmail.com', 'Joelle', 13100, 'Aix-en-Provence'),
(3, 'Fraysine', 'mfraysine', '3', 'fraysine.jpg', '0621724462', 'frayssinhes.marine@gmail.com', 'Marine', 13400, 'Aubagne'),
(4, 'Garnier', 'mgarnier', '4', 'garnier.jpg', '0680875914', 'garnier.laure@gmail.com', 'Laure', 13500, 'Martigues'),
(5, 'Michaud', 'mmichaud', '5', 'michaud.jpg', '0622802939', 'michaud.christian@gmail.com', 'Christian', 13127, 'Vitrolles'),
(6, 'Markovitch', 'Yan.01', '6', 'D:\\gestion securite\\GESTION SECURITE\\GESTION SECURITE\\Resources\\black.jpg', '0645335136', 'markovitch.yan@gmail.com', 'Yan', 13300, 'Salon-de-Provence'),
(8, 'Nicolas', NULL, '8', 'nicola.jpg', '0662805292', 'nicolas.julien@gmail.com', 'Julien', 13600, 'La Ciotat'),
(10, 'BOUABBOUNE', 'Bou.01', '9', 'D:\\\\gestion securite\\\\GESTION SECURITE\\\\GESTION SECURITE\\\\Resources\\\\AYMEN.jpg', '0666132680', 'test@gmail.com', 'Aymen', 13330, 'Pélissanne');

-- --------------------------------------------------------

--
-- Structure de la table `stage`
--

DROP TABLE IF EXISTS `stage`;
CREATE TABLE IF NOT EXISTS `stage` (
  `numero_eleve` varchar(4) COLLATE utf8_unicode_ci NOT NULL,
  `code_tuteur` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `date_debut` date DEFAULT NULL,
  `date_fin` date DEFAULT NULL,
  `nom_eleve` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `nom_entreprise` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nom_poste` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nom_tuteur` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nom_professeur` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`numero_eleve`,`code_tuteur`),
  KEY `code_tuteur` (`code_tuteur`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `stage`
--

INSERT INTO `stage` (`numero_eleve`, `code_tuteur`, `date_debut`, `date_fin`, `nom_eleve`, `nom_entreprise`, `nom_poste`, `nom_tuteur`, `nom_professeur`) VALUES
('E001', 'T1', '2024-05-01', '2024-07-31', 'COULANGE', 'TechCorp', 'Dirigeant', 'Laurent', 'Bruno'),
('E002', 'T2', '2024-05-01', '2024-07-31', 'DELPORTO', 'InnovaWeb', 'Assistante RH', 'Marie', 'Casta'),
('E003', 'T3', '2024-05-01', '2024-07-31', 'Marsel', 'MediGroup', 'Chef de projet', 'Paul', 'Fraysine'),
('E004', 'T4', '2024-05-01', '2024-07-31', 'AZZI', 'GreenCity', 'Directrice technique', 'Julie', 'Garnier'),
('E005', 'T5', '2024-05-01', '2024-07-31', 'BANDIERA', 'AgroFrance', 'Chargé de mission', 'Alain', 'Michaud'),
('E006', 'T6', '2024-05-01', '2024-07-31', 'BOURI', 'CyberLink', 'Responsable IT', 'Sophie', 'Markovitch'),
('E007', 'T7', '2024-05-01', '2024-07-31', 'CORDOVANA', 'BuildTech', 'Conducteur de travaux', 'Nicolas', NULL),
('E008', 'T8', '2024-05-01', '2024-07-31', 'DEBABO', 'BioHealth', 'Assistante', 'Emma ', 'Nicolas');

-- --------------------------------------------------------

--
-- Structure de la table `suivit`
--

DROP TABLE IF EXISTS `suivit`;
CREATE TABLE IF NOT EXISTS `suivit` (
  `numero_professeur` int(5) NOT NULL,
  `numero_eleve` varchar(4) COLLATE utf8_unicode_ci NOT NULL,
  `année` date NOT NULL,
  PRIMARY KEY (`numero_professeur`,`numero_eleve`,`année`),
  KEY `numero_eleve` (`numero_eleve`),
  KEY `année` (`année`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `suivit`
--

INSERT INTO `suivit` (`numero_professeur`, `numero_eleve`, `année`) VALUES
(1, 'E001', '2023-09-01'),
(2, 'E002', '2023-09-01'),
(3, 'E003', '2023-09-01'),
(4, 'E004', '2023-09-01'),
(5, 'E005', '2023-09-01'),
(6, 'E006', '2023-09-01'),
(7, 'E007', '2023-09-01'),
(8, 'E008', '2023-09-01');

-- --------------------------------------------------------

--
-- Structure de la table `tuteur`
--

DROP TABLE IF EXISTS `tuteur`;
CREATE TABLE IF NOT EXISTS `tuteur` (
  `code_tuteur` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `mail_tuter` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `téléphone_tuteur` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prenom_tuteur` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nom_tuteur` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nom_entreprise` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nom_poste` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`code_tuteur`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `tuteur`
--

INSERT INTO `tuteur` (`code_tuteur`, `mail_tuter`, `téléphone_tuteur`, `prenom_tuteur`, `nom_tuteur`, `nom_entreprise`, `nom_poste`) VALUES
('T1', 'laurent.martin@entreprise.com', '0726478311', 'Laurent', 'Martin', 'TechCorp', 'Dirigeant'),
('T2', 'marie.dupont@entreprise.com', '0712863243', 'Marie', 'Dupont', 'InnovaWeb', 'Assistante RH'),
('T3', 'paul.lefevre@entreprise.com', '0711507726', 'Paul', 'Lefevre', 'MediGroup', 'Chef de projet'),
('T4', 'julie.bernard@entreprise.com', '0747198419', 'Julie', 'Bernard', 'GreenCity', 'Directrice technique'),
('T5', 'alain.moreau@entreprise.com', '0740418391', 'Alain', 'Moreau', 'AgroFrance', 'Chargé de mission'),
('T6', 'sophie.robert@entreprise.com', '0738683031', 'Sophie', 'Robert', 'CyberLink', 'Responsable IT'),
('T7', 'nicolas.durand@entreprise.com', '0798325751', 'Nicolas', 'Durand', 'BuildTech', 'Conducteur de travaux'),
('T8', 'emma.renaud@entreprise.com', '0784598131', 'Emma', 'Renaud', 'BioHealth', 'Assistante'),
('T9', 'claude.perrin@entreprise.com', '0758493022', 'Claude', 'Perrin', 'EcoLogix', 'Directeur R&D'),
('T10', 'isabelle.faure@entreprise.com', '0762154382', 'Isabelle', 'Faure', 'Financia', 'Chargée de clientèle'),
('T11', 'thomas.garcia@entreprise.com', '0771145263', 'Thomas', 'Garcia', 'EduPlus', 'Formateur'),
('T12', 'camille.giraud@entreprise.com', '0782045163', 'Camille', 'Giraud', 'Archidom', 'Architecte'),
('T13', 'jerome.lemoine@entreprise.com', '0741639283', 'Jérôme', 'Lemoine', 'ServiTech', 'Manager opérationnel'),
('T14', 'anais.roger@entreprise.com', '0750924715', 'Anaïs', 'Roger', 'Design&Co', 'Responsable com.'),
('T15', 'vincent.meyer@entreprise.com', '0711947383', 'Vincent', 'Meyer', 'NetAccess', 'Technicien réseau'),
('T16', 'celine.barbier@entreprise.com', '0763478392', 'Céline', 'Barbier', 'SecureWare', 'Chef sécurité'),
('T17', 'sebastien.renaud@entreprise.com', '0778193831', 'Sébastien', 'Renaud', 'TravelOne', 'Consultant'),
('T18', 'lucie.roy@entreprise.com', '0739314752', 'Lucie', 'Roy', 'Logis+ ', 'Ingénieure'),
('T19', 'arnaud.gerard@entreprise.com', '0750937482', 'Arnaud', 'Gérard', 'PolyServices', 'Chef produit'),
('T20', 'elise.schmitt@entreprise.com', '0728491023', 'Élise', 'Schmitt', 'OrgaPro', 'Responsable logistique');

-- --------------------------------------------------------

--
-- Structure de la table `ville`
--

DROP TABLE IF EXISTS `ville`;
CREATE TABLE IF NOT EXISTS `ville` (
  `cde_ville` int(11) NOT NULL,
  `libel_ville` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`cde_ville`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `ville`
--

INSERT INTO `ville` (`cde_ville`, `libel_ville`) VALUES
(1300, 'Marseille'),
(13100, 'Aix-en-Provence'),
(13400, 'Aubagne'),
(13500, 'Martigues'),
(13300, 'Salon-de-Provence'),
(13800, 'Istres'),
(13127, 'Vitrolles'),
(13700, 'Marignane'),
(13600, 'La Ciotat'),
(13140, 'Miramas'),
(13120, 'Gardanne'),
(13170, 'Les Pennes-Mirabeau'),
(13190, 'Allauch'),
(13160, 'Châteaurenard'),
(13110, 'Port-de-Bouc'),
(13270, 'Fos-sur-Mer'),
(13130, 'Berre-l\'Étang'),
(13150, 'Tarascon'),
(13390, 'Auriol'),
(13360, 'Roquevaire'),
(13180, 'Gignac-la-Nerthe'),
(13380, 'Plan-de-Cuques'),
(13330, 'Pélissanne'),
(13340, 'Rognac'),
(13220, 'Châteauneuf-les-Martigues'),
(13310, 'Saint-Martin-de-Crau'),
(13580, 'La Fare-les-Oliviers'),
(13960, 'Sausset-les-Pins'),
(13260, 'Cassis');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
