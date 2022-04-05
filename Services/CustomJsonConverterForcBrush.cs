using c.Configuration;
using c.Configuration.Stringing;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestProject.Services
{
    public class CustomJsonConverterForcBrush : JsonConverter<cBrush>
    {
        public override cBrush Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
            )
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer,
            cBrush value,
            JsonSerializerOptions options
            )
        {
            string assemblyQualifiedName = value.SaveToString();

            writer.WriteStringValue(assemblyQualifiedName);
        }
    }
}
