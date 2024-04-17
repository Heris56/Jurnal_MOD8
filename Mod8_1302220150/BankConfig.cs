using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

public class BankConfig
{
	public const String Path = @"C:\Users\haika\Downloads\Jurnal online\Mod8_1302220150\Mod8_1302220150\TF_config.json";
	public String JSON = System.IO.File.ReadAllText(Path);

	[JsonPropertyName("lang")]
	public String config1 {  get; set; }

	[JsonPropertyName("transfer")]
	public Transfer TF { get; set; }
    public class Transfer
    {
		[JsonPropertyName("threshold")]
		public int config2 { get; set; }

		[JsonPropertyName("low_fee")]
		public int config3 { get; set; }

		[JsonPropertyName("high_fee")]
		public int config4 { get; set; }
    }
	[JsonPropertyName("methods")]
	public String[] config5 { get; set; }

	[JsonPropertyName("confirmation")]
	public Confirm confirm { get; set; } 
	public class Confirm
	{
		[JsonPropertyName("en")]
		public String config6 { get; set; }

		[JsonPropertyName("id")]
		public String config7 {  get; set; }
		
	}

    private void newconf()
    {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true,
        };
        String newJson = JsonSerializer.Serialize(JSON, options);
    }
    public void ubahlang(String lang)
    {
        Boolean valid = (lang == "en" || lang == "id");

        if (!valid)
        {
            throw new ArgumentException("tidak valid");
        }
        config1 = lang;
        newconf();
    }
}


