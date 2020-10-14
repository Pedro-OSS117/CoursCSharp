using System;

namespace CalculTVA
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declaration des variables
            float classicTVA = 20.0f;
            float primaryNeedTVA = 0.5f;

            float priceProductHT1 = 19.64f;
            int quantityProduct1 = 10;

            float priceProductHT2 = 254.50f;
            int quantityProduct2 = 2;

            // Calcul TTC (20%) pour produit 1
            float tvaProduct1 = priceProductHT1 * classicTVA / 100;

            float priceProductTTC1 =  tvaProduct1 + priceProductHT1;
            Console.WriteLine("Prix produit 1 TTC (20%) : " + priceProductTTC1);

            float priceTotalProductTTC1 = priceProductTTC1 * quantityProduct1;
            Console.WriteLine("Prix Total produit 1 (20%) : " + priceTotalProductTTC1);

            // Calcul TTC (20%) pour produit 2
            float tvaProduct2 = priceProductHT2 * classicTVA / 100;

            float priceProductTTC2 = tvaProduct2 + priceProductHT2;
            Console.WriteLine("Prix produit 2 TTC (20%) : " + priceProductTTC2);

            float priceTotalProductTTC2 = priceProductTTC2 * quantityProduct2;
            Console.WriteLine("Prix Total produit 2 (20%) : " + priceTotalProductTTC2);
            
            float totalPriceClassicTVA = priceTotalProductTTC1 + priceTotalProductTTC2;

            // Calcul TTC (5%) pour produit 1
            priceProductTTC1 = priceProductHT1 * primaryNeedTVA / 100 + priceProductHT1;
            Console.WriteLine("Prix produit 1 TTC (5%): " + priceProductTTC1);

            priceTotalProductTTC1 = priceProductTTC1 * quantityProduct1;
            Console.WriteLine("Prix Total produit 1 (5%): " + priceTotalProductTTC1);

            // Calcul TTC (5%) pour produit 2
            priceProductTTC2 = priceProductHT2 * primaryNeedTVA / 100 + priceProductHT2;
            Console.WriteLine("Prix produit 2 TTC (5%): " + priceProductTTC2);

            priceTotalProductTTC2 = priceProductTTC2 * quantityProduct2;
            Console.WriteLine("Prix Total produit 2 (5%): " + priceTotalProductTTC2);
            
            float totalHT = priceProductHT1 * quantityProduct1 + priceProductHT2 * quantityProduct2;

           // Total 
            Console.WriteLine("Prix Total HT de la note: " + totalHT);      

            float totalPricePrimaryNeedTVA = priceTotalProductTTC1 + priceTotalProductTTC2;
            Console.WriteLine("Prix Total TTC de la note (20%): " + totalPriceClassicTVA);

            Console.WriteLine("Prix Total TTC de la note (5%): " + totalPricePrimaryNeedTVA);

            float totalClassicTVA = tvaProduct1 * quantityProduct1 + tvaProduct2 * quantityProduct2;

            // Total des taxes
            Console.WriteLine("Total taxes a 20%: " + totalClassicTVA);  
        }
    }
}
