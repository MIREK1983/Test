using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace ReadGaebFiles
{
    class Program
    {
        static GAEB gaeb;
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines(@"C:\Users\Mirek\Desktop\Neubau_KITA_Wismarer_Werkstaett_1923095.p93");

            foreach (string line in file)
            {
                switch (line)
                {
                    case "#begin[GAEB]":
                        gaeb = new GAEB();
                        break;
                    case " #begin[GAEBInfo]":
                        gaeb.GAEBInfo = new GAEBInfo();
                        break;
                    case " #begin[PrjInfo]":
                        gaeb.PrjInfo = new PrjInfo();
                        break;
                    case " #begin[Bestellung]":
                        gaeb.Bestellung = new Bestellung();
                        break;
                    case "  #begin[BestInfo]":
                        gaeb.Bestellung.BestInfo = new BestInfo();
                        break;
                    case "  #begin[BestLieferant]":
                        gaeb.Bestellung.BestLieferant = new BestLieferant();
                        break;
                    case "   #begin[Adresse]":
                        gaeb.Bestellung.BestLieferant.LieferAdresse = new LieferAdresse();
                        break;
                    case "  #begin[BestKunde]":
                        gaeb.Bestellung.BestKunde = new BestKunde();
                        break;
                    case "   #begin[Adresse]":
                        gaeb.Bestellung.BestKunde.KundenAdresse = new KundenAdresse();
                        break;

                    default:
                        if (line.StartsWith("  [Version]"))
                            gaeb.GAEBInfo.Version = line.Replace("  [Version]", "").Replace("[end]", "");
                        else if (line.StartsWith("  [VersJahr]"))
                            gaeb.GAEBInfo.VersJahr = line.Replace("  [VersJahr]", "").Replace("[end]", "");
                        else if (line.StartsWith("  [VersMon]"))
                            gaeb.GAEBInfo.VersMon = line.Replace("  [VersMon]", "").Replace("[end]", "");
                        else if (line.StartsWith("  [Datum]"))
                            gaeb.GAEBInfo.Datum = line.Replace("  [Datum]", "").Replace("[end]", "");
                        else if (line.StartsWith("  [ProgSystem]"))
                            gaeb.GAEBInfo.ProgSystem = line.Replace("  [ProgSystem]", "").Replace("[end]", "");
                        else if (line.StartsWith("  [Zeichensatz]"))
                            gaeb.GAEBInfo.Zeichensatz = line.Replace("  [Zeichensatz]", "").Replace("[end]", "");
                        else if (line.StartsWith("  [_GAEBXML]"))
                            gaeb.GAEBInfo.GaebXml = line.Replace("  [_GAEBXML]", "").Replace("[end]", "");
                        else if (line.StartsWith("  [Uhrzeit]"))
                            gaeb.GAEBInfo.Uhrzeit = line.Replace("  [Uhrzeit]", "").Replace("[end]", "");
                        else if (line.StartsWith("  [Name]"))
                            gaeb.PrjInfo.Name = line.Replace("  [Name]", "").Replace("[end]", "");
                        else if (line.StartsWith("  [Bez]"))
                            gaeb.PrjInfo.Bez = line.Replace("  [Bez]", "").Replace("[end]", "");
                        else if (line.StartsWith("  [Beschreib]"))
                            gaeb.PrjInfo.Beschreib = line.Replace("  [Beschreib]", "").Replace("[end]", "");
                        else if (line.StartsWith("  [DP]"))
                            gaeb.Bestellung.Dp = line.Replace("  [DP]", "").Replace("[end]", "");
                        else if (line.StartsWith("   [AnfrNrKunde]"))
                            gaeb.Bestellung.BestInfo.AnfrNrKunde = line.Replace("   [AnfrNrKunde]", "").Replace("[end]", "");
                        else if (line.StartsWith("   [WaeBez]"))
                            gaeb.Bestellung.BestInfo.WaeBez = line.Replace("   [WaeBez]", "").Replace("[end]", "");
                        else if (line.StartsWith("   [AbgabeDatum]"))
                            gaeb.Bestellung.BestInfo.AbgabeDatum = line.Replace("   [AbgabeDatum]", "").Replace("[end]", "");
                        else if (line.StartsWith("    [Name1]"))
                            gaeb.Bestellung.BestLieferant.LieferAdresse.Name1 = line.Replace("    [Name1]", "").Replace("[end]", "");
                        else if (line.StartsWith("    [Strasse]"))
                            gaeb.Bestellung.BestLieferant.LieferAdresse.Strasse = line.Replace("    [Strasse]", "").Replace("[end]", "");
                        else if (line.StartsWith("    [PLZ]"))
                            gaeb.Bestellung.BestLieferant.LieferAdresse.PLZ = line.Replace("    [PLZ]", "").Replace("[end]", "");
                        else if (line.StartsWith("    [Ort]"))
                            gaeb.Bestellung.BestLieferant.LieferAdresse.Ort = line.Replace("    [Ort]", "").Replace("[end]", "");
                        break;
                }

                //Console.WriteLine(line);
            }

        }
    }
}
