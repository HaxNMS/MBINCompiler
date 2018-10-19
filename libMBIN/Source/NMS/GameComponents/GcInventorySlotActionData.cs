using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C, GUID = 0xFD920194C02A5656)]
    public class GcInventorySlotActionData : GameComponentType {

        /* 0x00 */ public bool Loops;                       // 0
        /* 0x01 */ public bool Glows;
        /* 0x02 */ public bool Scales;
        /* 0x04 */ public float Time;                       // 3F800000h
        /* 0x08 */ public float ScaleAtMin;                 // 3F800000h
        /* 0x0C */ public float SclaeAtMax;                 // 40000000h
        /* 0x10 */ public TkCurveType AnimCurve;
        /* 0x14 */ public GcAudioWwiseEvents SuitAudio;
        /* 0x18 */ public GcAudioWwiseEvents ActionAudio;
    }
}
