namespace Livraria.Application.Utils
{
    public static class Converters
    {
        public static DateTime? ConverterParaTimeStamp(DateTime? data)
        {
            if (data is DateTime)
            {
                return DateTime.SpecifyKind((DateTime)data, DateTimeKind.Utc);
            }

            return data;
        }
    }
}
