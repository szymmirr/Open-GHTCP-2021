using GHNamespace9;
using GHNamespaceC;
using GHNamespaceE;
using GHNamespaceF;
using GuitarHero.Songlist;

namespace GHNamespace8
{
    public class Class246 : QbEditor
    {
        private readonly Gh3Songlist _gh3Songlist0;

        private readonly ZzPakNode2 _class3180;

        private readonly string _string0;

        private readonly int _int0;

        private readonly bool _bool0;

        public Class246(int int1, ZzPakNode2 class3181, Gh3Songlist gh3Songlist1, bool bool1)
        {
            _string0 = gh3Songlist1.Class2140.method_0(int1);
            _int0 = int1;
            _class3180 = class3181;
            _gh3Songlist0 = gh3Songlist1;
            _bool0 = bool1;
        }

        public override void CreateCustomMenu()
        {
            string text;
            ZzGenericNode1 @class;
            if (!_class3180.zzQbFileExists(text = "scripts\\guitar\\custom_menu\\guitar_custom_progression.qb"))
            {
                _class3180.zzCreateQbFileFrom(text, new ZzGenericNode1());
                @class = _class3180.ZzGetNode1(text);
                @class.addChild(new IntegerRootNode("custom_setlist_bitmask", text, 0));
            }
            else
            {
                @class = _class3180.ZzGetNode1(text);
            }
            if (_bool0)
            {
                @class.addChild(new StructurePointerRootNode(_int0, text, _gh3Songlist0.Dictionary1[_int0].method_1()));
                @class.addChild(new StructurePointerRootNode(_gh3Songlist0.method_10(_int0), text,
                    _gh3Songlist0.method_11(_int0).method_6()));
            }
            else
            {
                try
                {
                    @class.zzFindNode(new StructurePointerRootNode(_int0)).Remove();
                    @class.zzFindNode(new StructurePointerRootNode(_gh3Songlist0.method_10(_int0))).Remove();
                }
                catch
                {
                }
                _gh3Songlist0.CustomBitMask &= ~_gh3Songlist0.method_11(_int0).CustomBit;
                _gh3Songlist0.Gh3SetlistList.Remove(_gh3Songlist0.method_10(_int0));
                _gh3Songlist0.Dictionary1.Remove(_int0);
                _gh3Songlist0.Class2140.Remove(_gh3Songlist0.Class2140.method_0(_int0));
            }
            @class.zzFindNode(new IntegerRootNode("custom_setlist_bitmask")).method_8(_gh3Songlist0.CustomBitMask);
        }

        public override string ToString()
        {
            return (_bool0 ? "Create" : "Delete") + " Setlist: " + _string0;
        }

        public override bool Equals(QbEditor other)
        {
            return other is Class246 && (other as Class246)._int0 == _int0;
        }
    }
}