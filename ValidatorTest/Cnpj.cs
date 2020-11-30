namespace ValidatorTest
{
    public class Cnpj
    {
        public static bool IsValidCnpj(string cnpj)
        {
            int[] mult1 = new [] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = new [] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj
                .Trim()
                .Replace(".", "")
                .Replace("-", "")
                .Replace("/", "");
            
            if (cnpj.Length != 14)
                return false;

            string tempCnpj = cnpj
                .Substring(0, 12);
            
            int sum = 0;

            for (int i = 0; i < 12; i++)
                sum += int
                    .Parse(tempCnpj[i].ToString()) * mult1[i];

            int remains = (sum % 11);
            if (remains < 2)
                remains = 0;
            else
                remains = 11 - remains;

            string digit = remains.ToString();
            tempCnpj = tempCnpj + digit;
            sum = 0;
            for (int i = 0; i < 13; i++)
                sum += int
                    .Parse(tempCnpj[i].ToString()) * mult2[i];

            remains = (sum % 11);
            if (remains < 2)
                remains = 0;
            else
                remains = 11 - remains;

            digit = digit + remains.ToString();

            return cnpj.EndsWith(digit);
        }
    }
}