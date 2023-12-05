namespace LB_2.Model.OperatorCompany
{
    internal class CompanyValidator
    {
        public bool ParametersIsValid(string name, string edrpoy) => 
            !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(edrpoy);
    }
}