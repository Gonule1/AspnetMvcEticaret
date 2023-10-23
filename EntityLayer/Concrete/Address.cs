using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete;

public class Address
{
    [Key] 
    public int AddressId { get; set; }
    public string AddressTitle { get; set; }
    public string AddressDescription { get; set; }
    public string The {  get; set; }
    public string District {  get; set; }
    public string Neighbourhood {  get; set; }
    public string PostCode { get; set; }

}
