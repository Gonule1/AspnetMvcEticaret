using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete;

public class Pay
{
    [Key]
    public int PayId { get; set; }
    public string UserName { get; set; }
    public int CartNumber { get; set; }
    public int SecurityNumber{ get; set; }
    public string CartHasName { get; set; }
    public int ExpYear {  get; set; }
    public int ExpMonth { get; set; }
    public int AddressId {  get; set; }
    public virtual Address Addres { get; set; }



}
