using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public enum EnumOrderState
{
    [Display(Name ="Onay Bekleniyor")]
    Bekleniyor,
    [Display(Name ="Tamamlandı")]
    Tamamlandı,
    [Display(Name ="Paketlendi")]
    Paketlendi,
    [Display(Name ="Kargolandı")]
    Kargolandı
}