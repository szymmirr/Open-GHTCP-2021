using System;
using GHNamespaceB;
using GHNamespaceF;

namespace GuitarHero
{
	[Serializable]
	public class GhLink
	{
		public string Path;

		public int Setlist;

		public int Progression;

		public GhLink(int int0) : this(int0, -2140143824)
		{
		}

		public GhLink(int int0, int int1) : this("scripts\\guitar\\custom_menu\\guitar_custom_progression.qb", int0, int1)
		{
		}

		public GhLink(string string0, int int0, int int1)
		{
			Path = string0;
			Setlist = int0;
			Progression = int1;
		}

		public GhLink(string string0, StructureHeaderNode class2860)
		{
			Path = string0;
			method_0(class2860);
		}

		public void method_0(StructureHeaderNode class2860)
		{
			Setlist = class2860.method_5(new TagStructureNode("tier_global")).method_10();
			Progression = class2860.method_5(new TagStructureNode("progression_global")).method_10();
		}

		public StructureHeaderNode method_1()
		{
			var @class = new StructureHeaderNode();
			@class.method_3(new TagStructureNode("tier_global", Setlist));
			@class.method_3(new TagStructureNode("progression_global", Progression));
			return @class;
		}
	}
}
