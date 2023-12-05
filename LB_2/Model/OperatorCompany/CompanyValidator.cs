namespace LB_2.Model.OperatorCompany
{
    static class CompanyValidator
    {
        public static bool ParametersIsValid(string name, string edrpoy) => 
            !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(edrpoy);
    }
}