ENUMS

USE WHERE YOU HAVE A NUMBER OF RELATED CONSTANTS

public enum ShippingMethod : byte
{
	regularAirMail = 1;
	RegisteredAirMail = 2;
	Express = 3;
}

var method = ShippingMethod.Express;