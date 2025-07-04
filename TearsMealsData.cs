#pragma warning disable

namespace TearsMeals
{ 
    public class TearsMealsData
    {
        public Systemdata SystemData { get; set; }
        public Effectdata EffectData { get; set; }
        public Materialdata MaterialData { get; set; }
        public Localedata LocaleData { get; set; }
        public Recipedata[] RecipeData { get; set; }
        public Singlerecipedata[] SingleRecipeData { get; set; }
        public string[] RecipeCardData { get; set; }
    }

    public class Systemdata
    {
        public string EnemyExtractActorName { get; set; }
        public string FailActorName { get; set; }
        public int FailLifeRecover { get; set; }
        public string FairyActorName { get; set; }
        public float LifeRecoverRate { get; set; }
        public Priceratelist[] PriceRateList { get; set; }
        public float SubtleLifeRecover { get; set; }
        public float SubtleLifeRecoverRate { get; set; }
        public int SuperSuccessAddEffectiveTime { get; set; }
        public Supersuccessratelist[] SuperSuccessRateList { get; set; }
    }

    public class Priceratelist
    {
        public int MaterialNum { get; set; }
        public float Rate { get; set; }
    }

    public class Supersuccessratelist
    {
        public int MaterialTypeNum { get; set; }
        public float Rate { get; set; }
    }

    public class Effectdata
    {
        public Liferecover LifeRecover { get; set; }
        public Lifemaxup LifeMaxUp { get; set; }
        public Staminarecover StaminaRecover { get; set; }
        public Exstaminamaxup ExStaminaMaxUp { get; set; }
        public Resisthot ResistHot { get; set; }
        public Resistcold ResistCold { get; set; }
        public Resistelectric ResistElectric { get; set; }
        public Allspeed AllSpeed { get; set; }
        public Attackup AttackUp { get; set; }
        public Defenseup DefenseUp { get; set; }
        public Quietnessup QuietnessUp { get; set; }
        public Resistburn ResistBurn { get; set; }
        public Twicejump TwiceJump { get; set; }
        public Emergencyavoid EmergencyAvoid { get; set; }
        public Liferepair LifeRepair { get; set; }
        public Lightemission LightEmission { get; set; }
        public Notslippy NotSlippy { get; set; }
        public Swimspeedup SwimSpeedUp { get; set; }
        public Attackupcold AttackUpCold { get; set; }
        public Attackuphot AttackUpHot { get; set; }
        public Attackupthunderstorm AttackUpThunderstorm { get; set; }
        public Miasmaguard MiasmaGuard { get; set; }
    }

    public class Liferecover
    {
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Lifemaxup
    {
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Staminarecover
    {
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Exstaminamaxup
    {
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Resisthot
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Resistcold
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Resistelectric
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Allspeed
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Attackup
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Defenseup
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Quietnessup
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Resistburn
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Twicejump
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Emergencyavoid
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Liferepair
    {
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Lightemission
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Notslippy
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Swimspeedup
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Attackupcold
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Attackuphot
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Attackupthunderstorm
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Miasmaguard
    {
        public int BaseTime { get; set; }
        public int MinLv { get; set; }
        public int MaxLv { get; set; }
        public int SuperSuccessAddVolume { get; set; }
        public float Rate { get; set; }
        public int Priority { get; set; }
    }

    public class Materialdata
    {
        public Animal_Insect_A Animal_Insect_A { get; set; }
        public Animal_Insect_AA Animal_Insect_AA { get; set; }
        public Animal_Insect_AB Animal_Insect_AB { get; set; }
        public Animal_Insect_AG Animal_Insect_AG { get; set; }
        public Animal_Insect_AH Animal_Insect_AH { get; set; }
        public Animal_Insect_AI Animal_Insect_AI { get; set; }
        public Animal_Insect_B Animal_Insect_B { get; set; }
        public Animal_Insect_C Animal_Insect_C { get; set; }
        public Animal_Insect_E Animal_Insect_E { get; set; }
        public Animal_Insect_F Animal_Insect_F { get; set; }
        public Animal_Insect_G Animal_Insect_G { get; set; }
        public Animal_Insect_H Animal_Insect_H { get; set; }
        public Animal_Insect_I Animal_Insect_I { get; set; }
        public Animal_Insect_M Animal_Insect_M { get; set; }
        public Animal_Insect_N Animal_Insect_N { get; set; }
        public Animal_Insect_P Animal_Insect_P { get; set; }
        public Animal_Insect_Q Animal_Insect_Q { get; set; }
        public Animal_Insect_R Animal_Insect_R { get; set; }
        public Animal_Insect_S Animal_Insect_S { get; set; }
        public Animal_Insect_T Animal_Insect_T { get; set; }
        public Animal_Insect_X Animal_Insect_X { get; set; }
        public Beehome BeeHome { get; set; }
        public Bombfruit BombFruit { get; set; }
        public Confusionfruit ConfusionFruit { get; set; }
        public Electricalfruit ElectricalFruit { get; set; }
        public Firefruit FireFruit { get; set; }
        public Fldobj_Pinecone_A_01 FldObj_Pinecone_A_01 { get; set; }
        public Icefruit IceFruit { get; set; }
        public Item_Enemy_01 Item_Enemy_01 { get; set; }
        public Item_Enemy_02 Item_Enemy_02 { get; set; }
        public Item_Enemy_04 Item_Enemy_04 { get; set; }
        public Item_Enemy_05 Item_Enemy_05 { get; set; }
        public Item_Enemy_07 Item_Enemy_07 { get; set; }
        public Item_Enemy_08 Item_Enemy_08 { get; set; }
        public Item_Enemy_100 Item_Enemy_100 { get; set; }
        public Item_Enemy_101 Item_Enemy_101 { get; set; }
        public Item_Enemy_102 Item_Enemy_102 { get; set; }
        public Item_Enemy_103 Item_Enemy_103 { get; set; }
        public Item_Enemy_104 Item_Enemy_104 { get; set; }
        public Item_Enemy_105 Item_Enemy_105 { get; set; }
        public Item_Enemy_106 Item_Enemy_106 { get; set; }
        public Item_Enemy_107 Item_Enemy_107 { get; set; }
        public Item_Enemy_108 Item_Enemy_108 { get; set; }
        public Item_Enemy_109 Item_Enemy_109 { get; set; }
        public Item_Enemy_114 Item_Enemy_114 { get; set; }
        public Item_Enemy_115 Item_Enemy_115 { get; set; }
        public Item_Enemy_116 Item_Enemy_116 { get; set; }
        public Item_Enemy_117 Item_Enemy_117 { get; set; }
        public Item_Enemy_118 Item_Enemy_118 { get; set; }
        public Item_Enemy_119 Item_Enemy_119 { get; set; }
        public Item_Enemy_121 Item_Enemy_121 { get; set; }
        public Item_Enemy_123 Item_Enemy_123 { get; set; }
        public Item_Enemy_124 Item_Enemy_124 { get; set; }
        public Item_Enemy_13 Item_Enemy_13 { get; set; }
        public Item_Enemy_130 Item_Enemy_130 { get; set; }
        public Item_Enemy_131 Item_Enemy_131 { get; set; }
        public Item_Enemy_132 Item_Enemy_132 { get; set; }
        public Item_Enemy_133 Item_Enemy_133 { get; set; }
        public Item_Enemy_134 Item_Enemy_134 { get; set; }
        public Item_Enemy_135 Item_Enemy_135 { get; set; }
        public Item_Enemy_136 Item_Enemy_136 { get; set; }
        public Item_Enemy_14 Item_Enemy_14 { get; set; }
        public Item_Enemy_142 Item_Enemy_142 { get; set; }
        public Item_Enemy_143 Item_Enemy_143 { get; set; }
        public Item_Enemy_144 Item_Enemy_144 { get; set; }
        public Item_Enemy_148 Item_Enemy_148 { get; set; }
        public Item_Enemy_149 Item_Enemy_149 { get; set; }
        public Item_Enemy_15 Item_Enemy_15 { get; set; }
        public Item_Enemy_150 Item_Enemy_150 { get; set; }
        public Item_Enemy_151 Item_Enemy_151 { get; set; }
        public Item_Enemy_153 Item_Enemy_153 { get; set; }
        public Item_Enemy_154 Item_Enemy_154 { get; set; }
        public Item_Enemy_155 Item_Enemy_155 { get; set; }
        public Item_Enemy_156 Item_Enemy_156 { get; set; }
        public Item_Enemy_157 Item_Enemy_157 { get; set; }
        public Item_Enemy_158 Item_Enemy_158 { get; set; }
        public Item_Enemy_159 Item_Enemy_159 { get; set; }
        public Item_Enemy_16 Item_Enemy_16 { get; set; }
        public Item_Enemy_160 Item_Enemy_160 { get; set; }
        public Item_Enemy_166 Item_Enemy_166 { get; set; }
        public Item_Enemy_167 Item_Enemy_167 { get; set; }
        public Item_Enemy_168 Item_Enemy_168 { get; set; }
        public Item_Enemy_169 Item_Enemy_169 { get; set; }
        public Item_Enemy_17 Item_Enemy_17 { get; set; }
        public Item_Enemy_18 Item_Enemy_18 { get; set; }
        public Item_Enemy_181 Item_Enemy_181 { get; set; }
        public Item_Enemy_182 Item_Enemy_182 { get; set; }
        public Item_Enemy_183 Item_Enemy_183 { get; set; }
        public Item_Enemy_184 Item_Enemy_184 { get; set; }
        public Item_Enemy_186 Item_Enemy_186 { get; set; }
        public Item_Enemy_187 Item_Enemy_187 { get; set; }
        public Item_Enemy_188 Item_Enemy_188 { get; set; }
        public Item_Enemy_189 Item_Enemy_189 { get; set; }
        public Item_Enemy_19 Item_Enemy_19 { get; set; }
        public Item_Enemy_190 Item_Enemy_190 { get; set; }
        public Item_Enemy_191 Item_Enemy_191 { get; set; }
        public Item_Enemy_192 Item_Enemy_192 { get; set; }
        public Item_Enemy_193 Item_Enemy_193 { get; set; }
        public Item_Enemy_20 Item_Enemy_20 { get; set; }
        public Item_Enemy_208 Item_Enemy_208 { get; set; }
        public Item_Enemy_21 Item_Enemy_21 { get; set; }
        public Item_Enemy_210 Item_Enemy_210 { get; set; }
        public Item_Enemy_211 Item_Enemy_211 { get; set; }
        public Item_Enemy_212 Item_Enemy_212 { get; set; }
        public Item_Enemy_213 Item_Enemy_213 { get; set; }
        public Item_Enemy_214 Item_Enemy_214 { get; set; }
        public Item_Enemy_215 Item_Enemy_215 { get; set; }
        public Item_Enemy_216 Item_Enemy_216 { get; set; }
        public Item_Enemy_217 Item_Enemy_217 { get; set; }
        public Item_Enemy_218 Item_Enemy_218 { get; set; }
        public Item_Enemy_228 Item_Enemy_228 { get; set; }
        public Item_Enemy_229 Item_Enemy_229 { get; set; }
        public Item_Enemy_230 Item_Enemy_230 { get; set; }
        public Item_Enemy_231 Item_Enemy_231 { get; set; }
        public Item_Enemy_24 Item_Enemy_24 { get; set; }
        public Item_Enemy_25 Item_Enemy_25 { get; set; }
        public Item_Enemy_32 Item_Enemy_32 { get; set; }
        public Item_Enemy_33 Item_Enemy_33 { get; set; }
        public Item_Enemy_34 Item_Enemy_34 { get; set; }
        public Item_Enemy_38 Item_Enemy_38 { get; set; }
        public Item_Enemy_39 Item_Enemy_39 { get; set; }
        public Item_Enemy_40 Item_Enemy_40 { get; set; }
        public Item_Enemy_41 Item_Enemy_41 { get; set; }
        public Item_Enemy_42 Item_Enemy_42 { get; set; }
        public Item_Enemy_43 Item_Enemy_43 { get; set; }
        public Item_Enemy_44 Item_Enemy_44 { get; set; }
        public Item_Enemy_45 Item_Enemy_45 { get; set; }
        public Item_Enemy_46 Item_Enemy_46 { get; set; }
        public Item_Enemy_47 Item_Enemy_47 { get; set; }
        public Item_Enemy_49 Item_Enemy_49 { get; set; }
        public Item_Enemy_50 Item_Enemy_50 { get; set; }
        public Item_Enemy_51 Item_Enemy_51 { get; set; }
        public Item_Enemy_53 Item_Enemy_53 { get; set; }
        public Item_Enemy_54 Item_Enemy_54 { get; set; }
        public Item_Enemy_55 Item_Enemy_55 { get; set; }
        public Item_Enemy_57 Item_Enemy_57 { get; set; }
        public Item_Enemy_58 Item_Enemy_58 { get; set; }
        public Item_Enemy_59 Item_Enemy_59 { get; set; }
        public Item_Enemy_60 Item_Enemy_60 { get; set; }
        public Item_Enemy_64 Item_Enemy_64 { get; set; }
        public Item_Enemy_66 Item_Enemy_66 { get; set; }
        public Item_Enemy_67 Item_Enemy_67 { get; set; }
        public Item_Enemy_69 Item_Enemy_69 { get; set; }
        public Item_Enemy_77 Item_Enemy_77 { get; set; }
        public Item_Enemy_78 Item_Enemy_78 { get; set; }
        public Item_Enemy_79 Item_Enemy_79 { get; set; }
        public Item_Enemy_80 Item_Enemy_80 { get; set; }
        public Item_Enemy_89 Item_Enemy_89 { get; set; }
        public Item_Enemy_90 Item_Enemy_90 { get; set; }
        public Item_Enemy_91 Item_Enemy_91 { get; set; }
        public Item_Enemy_92 Item_Enemy_92 { get; set; }
        public Item_Fishget_A Item_FishGet_A { get; set; }
        public Item_Fishget_AA Item_FishGet_AA { get; set; }
        public Item_Fishget_AC Item_FishGet_AC { get; set; }
        public Item_Fishget_B Item_FishGet_B { get; set; }
        public Item_Fishget_C Item_FishGet_C { get; set; }
        public Item_Fishget_D Item_FishGet_D { get; set; }
        public Item_Fishget_E Item_FishGet_E { get; set; }
        public Item_Fishget_F Item_FishGet_F { get; set; }
        public Item_Fishget_G Item_FishGet_G { get; set; }
        public Item_Fishget_H Item_FishGet_H { get; set; }
        public Item_Fishget_I Item_FishGet_I { get; set; }
        public Item_Fishget_J Item_FishGet_J { get; set; }
        public Item_Fishget_L Item_FishGet_L { get; set; }
        public Item_Fishget_M Item_FishGet_M { get; set; }
        public Item_Fishget_X Item_FishGet_X { get; set; }
        public Item_Fishget_Z Item_FishGet_Z { get; set; }
        public Item_Fruit_A Item_Fruit_A { get; set; }
        public Item_Fruit_B Item_Fruit_B { get; set; }
        public Item_Fruit_C Item_Fruit_C { get; set; }
        public Item_Fruit_E Item_Fruit_E { get; set; }
        public Item_Fruit_F Item_Fruit_F { get; set; }
        public Item_Fruit_G Item_Fruit_G { get; set; }
        public Item_Fruit_H Item_Fruit_H { get; set; }
        public Item_Fruit_I Item_Fruit_I { get; set; }
        public Item_Fruit_J Item_Fruit_J { get; set; }
        public Item_Fruit_K Item_Fruit_K { get; set; }
        public Item_Fruit_L Item_Fruit_L { get; set; }
        public Item_Fruit_M Item_Fruit_M { get; set; }
        public Item_Fruit_N Item_Fruit_N { get; set; }
        public Item_Fruit_P Item_Fruit_P { get; set; }
        public Item_Insectget_K Item_InsectGet_K { get; set; }
        public Item_Insectget_O Item_InsectGet_O { get; set; }
        public Item_Insectget_Z Item_InsectGet_Z { get; set; }
        public Item_Kingscale Item_KingScale { get; set; }
        public Item_Material_01 Item_Material_01 { get; set; }
        public Item_Material_02 Item_Material_02 { get; set; }
        public Item_Material_03 Item_Material_03 { get; set; }
        public Item_Material_04 Item_Material_04 { get; set; }
        public Item_Material_05 Item_Material_05 { get; set; }
        public Item_Material_06 Item_Material_06 { get; set; }
        public Item_Material_07 Item_Material_07 { get; set; }
        public Item_Material_08 Item_Material_08 { get; set; }
        public Item_Material_09 Item_Material_09 { get; set; }
        public Item_Material_10 Item_Material_10 { get; set; }
        public Item_Material_11 Item_Material_11 { get; set; }
        public Item_Meat_01 Item_Meat_01 { get; set; }
        public Item_Meat_02 Item_Meat_02 { get; set; }
        public Item_Meat_06 Item_Meat_06 { get; set; }
        public Item_Meat_07 Item_Meat_07 { get; set; }
        public Item_Meat_11 Item_Meat_11 { get; set; }
        public Item_Meat_12 Item_Meat_12 { get; set; }
        public Item_Mushroomget_D Item_MushroomGet_D { get; set; }
        public Item_Mushroomget_K Item_MushroomGet_K { get; set; }
        public Item_Mushroom_A Item_Mushroom_A { get; set; }
        public Item_Mushroom_B Item_Mushroom_B { get; set; }
        public Item_Mushroom_C Item_Mushroom_C { get; set; }
        public Item_Mushroom_E Item_Mushroom_E { get; set; }
        public Item_Mushroom_F Item_Mushroom_F { get; set; }
        public Item_Mushroom_H Item_Mushroom_H { get; set; }
        public Item_Mushroom_J Item_Mushroom_J { get; set; }
        public Item_Mushroom_L Item_Mushroom_L { get; set; }
        public Item_Mushroom_M Item_Mushroom_M { get; set; }
        public Item_Mushroom_N Item_Mushroom_N { get; set; }
        public Item_Mushroom_O Item_Mushroom_O { get; set; }
        public Item_Mushroom_P Item_Mushroom_P { get; set; }
        public Item_Ore_A Item_Ore_A { get; set; }
        public Item_Ore_B Item_Ore_B { get; set; }
        public Item_Ore_C Item_Ore_C { get; set; }
        public Item_Ore_D Item_Ore_D { get; set; }
        public Item_Ore_E Item_Ore_E { get; set; }
        public Item_Ore_F Item_Ore_F { get; set; }
        public Item_Ore_G Item_Ore_G { get; set; }
        public Item_Ore_H Item_Ore_H { get; set; }
        public Item_Ore_I Item_Ore_I { get; set; }
        public Item_Ore_J Item_Ore_J { get; set; }
        public Item_Ore_L Item_Ore_L { get; set; }
        public Item_Ore_M Item_Ore_M { get; set; }
        public Item_Plantget_A Item_PlantGet_A { get; set; }
        public Item_Plantget_B Item_PlantGet_B { get; set; }
        public Item_Plantget_C Item_PlantGet_C { get; set; }
        public Item_Plantget_E Item_PlantGet_E { get; set; }
        public Item_Plantget_F Item_PlantGet_F { get; set; }
        public Item_Plantget_G Item_PlantGet_G { get; set; }
        public Item_Plantget_H Item_PlantGet_H { get; set; }
        public Item_Plantget_I Item_PlantGet_I { get; set; }
        public Item_Plantget_J Item_PlantGet_J { get; set; }
        public Item_Plantget_L Item_PlantGet_L { get; set; }
        public Item_Plantget_M Item_PlantGet_M { get; set; }
        public Item_Plantget_O Item_PlantGet_O { get; set; }
        public Item_Plantget_Q Item_PlantGet_Q { get; set; }
        public Item_Plantget_R Item_PlantGet_R { get; set; }
        public Item_Plantget_S Item_PlantGet_S { get; set; }
        public Item_Plantget_U Item_PlantGet_U { get; set; }
        public Item_Weapon_01 Item_Weapon_01 { get; set; }
        public Lightball_Large LightBall_Large { get; set; }
        public Lightball_Small LightBall_Small { get; set; }
        public Lightfruit LightFruit { get; set; }
        public Obj_Firewoodbundle Obj_FireWoodBundle { get; set; }
        public Smokefruit SmokeFruit { get; set; }
        public Waterfruit WaterFruit { get; set; }
    }

    public class Animal_Insect_A
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_AA
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_AB
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_AG
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_AH
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_AI
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_B
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Animal_Insect_C
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_E
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_F
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Animal_Insect_G
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_H
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_I
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_M
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Animal_Insect_N
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_P
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_Q
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_R
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_S
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_T
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Animal_Insect_X
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Beehome
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Bombfruit
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Confusionfruit
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Electricalfruit
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Firefruit
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Fldobj_Pinecone_A_01
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Icefruit
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_01
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_02
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_04
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_05
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_07
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_08
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_100
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_101
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_102
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_103
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_104
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_105
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_106
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_107
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_108
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_109
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_114
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_115
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_116
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_117
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_118
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_119
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_121
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_123
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_124
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_13
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_130
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_131
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_132
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_133
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_134
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_135
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_136
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_14
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_142
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_143
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_144
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_148
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_149
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_15
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_150
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_151
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_153
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_154
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_155
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_156
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_157
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_158
    {
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_159
    {
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_16
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_160
    {
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_166
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_167
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_168
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_169
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_17
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_18
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_181
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_182
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_183
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_184
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_186
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_187
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_188
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_189
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_19
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_190
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_191
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_192
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_193
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_20
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_208
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_21
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_210
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_211
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_212
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_213
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_214
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_215
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_216
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_217
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_218
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_228
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_229
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_230
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_231
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_24
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_25
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_32
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_33
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_34
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_38
    {
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public bool CookValue1 { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_39
    {
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public bool CookValue1 { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_40
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_41
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_42
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_43
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Enemy_44
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_45
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_46
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_47
    {
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public bool CookValue1 { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_49
    {
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public bool CookValue1 { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_50
    {
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public bool CookValue1 { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_51
    {
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public bool CookValue1 { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_53
    {
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public bool CookValue1 { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_54
    {
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public bool CookValue1 { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_55
    {
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public bool CookValue1 { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_57
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_58
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_59
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_60
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_64
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_66
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_67
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_69
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_77
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_78
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_79
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_80
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_89
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_90
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_91
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Enemy_92
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_A
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_AA
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_AC
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_B
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_C
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_D
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_E
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_F
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_G
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_H
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_I
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_J
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_L
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_M
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_X
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fishget_Z
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Fruit_A
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Fruit_B
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Fruit_C
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Fruit_E
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Fruit_F
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Fruit_G
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Fruit_H
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Fruit_I
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Fruit_J
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Fruit_K
    {
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Fruit_L
    {
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int SpiceBoostHitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Fruit_M
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Fruit_N
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Fruit_P
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int CureEffectiveTime { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Insectget_K
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Insectget_O
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Insectget_Z
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Kingscale
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public bool CannotSell { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Material_01
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Material_02
    {
        public string CookTag { get; set; }
        public int CureEffectLevel { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Material_03
    {
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Material_04
    {
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Material_05
    {
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Material_06
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Material_07
    {
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Material_08
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Material_09
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Material_10
    {
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Material_11
    {
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Meat_01
    {
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Meat_02
    {
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Meat_06
    {
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Meat_07
    {
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Meat_11
    {
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Meat_12
    {
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroomget_D
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroomget_K
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroom_A
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroom_B
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroom_C
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroom_E
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroom_F
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroom_H
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroom_J
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroom_L
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroom_M
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroom_N
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroom_O
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Mushroom_P
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Ore_A
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Ore_B
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Ore_C
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Ore_D
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Ore_E
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Ore_F
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Ore_G
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Ore_H
    {
        public string CookTag { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Ore_I
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Ore_J
    {
        public string CookTag { get; set; }
        public bool CookLowPrice { get; set; }
        public int SpiceBoostEffectiveTime { get; set; }
        public int SpiceBoostSuccessRate { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Ore_L
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Ore_M
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Plantget_A
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_B
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_C
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_E
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_F
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_G
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_H
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_I
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_J
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_L
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_M
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_O
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_Q
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_R
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_S
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Item_Plantget_U
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Item_Weapon_01
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Lightball_Large
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Lightball_Small
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Lightfruit
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Obj_Firewoodbundle
    {
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
    }

    public class Smokefruit
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Waterfruit
    {
        public int PictureBookNum { get; set; }
        public string CookTag { get; set; }
        public int HitPointRecover { get; set; }
        public string CureEffectType { get; set; }
        public int CureEffectLevel { get; set; }
        public int CureEffectiveTime { get; set; }
        public int BuyingPrice { get; set; }
        public int SellingPrice { get; set; }
        public int PouchSortKey { get; set; }
    }

    public class Localedata
    {
        public string Material_Animal_Insect_A { get; set; }
        public string Material_Animal_Insect_A_Caption { get; set; }
        public string Material_Animal_Insect_AA { get; set; }
        public string Material_Animal_Insect_AA_Caption { get; set; }
        public string Material_Animal_Insect_AB { get; set; }
        public string Material_Animal_Insect_AB_Caption { get; set; }
        public string Material_Animal_Insect_AG { get; set; }
        public string Material_Animal_Insect_AG_Caption { get; set; }
        public string Material_Animal_Insect_AH { get; set; }
        public string Material_Animal_Insect_AH_Caption { get; set; }
        public string Material_Animal_Insect_AI { get; set; }
        public string Material_Animal_Insect_AI_Caption { get; set; }
        public string Material_Animal_Insect_B { get; set; }
        public string Material_Animal_Insect_B_Caption { get; set; }
        public string Material_Animal_Insect_C { get; set; }
        public string Material_Animal_Insect_C_Caption { get; set; }
        public string Material_Animal_Insect_E { get; set; }
        public string Material_Animal_Insect_E_Caption { get; set; }
        public string Material_Animal_Insect_F { get; set; }
        public string Material_Animal_Insect_F_Caption { get; set; }
        public string Material_Animal_Insect_G { get; set; }
        public string Material_Animal_Insect_G_Caption { get; set; }
        public string Material_Animal_Insect_H { get; set; }
        public string Material_Animal_Insect_H_Caption { get; set; }
        public string Material_Animal_Insect_I { get; set; }
        public string Material_Animal_Insect_I_Caption { get; set; }
        public string Material_Animal_Insect_M { get; set; }
        public string Material_Animal_Insect_M_Caption { get; set; }
        public string Material_Animal_Insect_N { get; set; }
        public string Material_Animal_Insect_N_Caption { get; set; }
        public string Material_Animal_Insect_P { get; set; }
        public string Material_Animal_Insect_P_Caption { get; set; }
        public string Material_Animal_Insect_Q { get; set; }
        public string Material_Animal_Insect_Q_Caption { get; set; }
        public string Material_Animal_Insect_R { get; set; }
        public string Material_Animal_Insect_R_Caption { get; set; }
        public string Material_Animal_Insect_S { get; set; }
        public string Material_Animal_Insect_S_Caption { get; set; }
        public string Material_Animal_Insect_T { get; set; }
        public string Material_Animal_Insect_T_Caption { get; set; }
        public string Material_Animal_Insect_X { get; set; }
        public string Material_Animal_Insect_X_Caption { get; set; }
        public string Material_BeeHome { get; set; }
        public string Material_BeeHome_Caption { get; set; }
        public string Material_BombFruit { get; set; }
        public string Material_BombFruit_Caption { get; set; }
        public string Material_ConfusionFruit { get; set; }
        public string Material_ConfusionFruit_Caption { get; set; }
        public string Material_ElectricalFruit { get; set; }
        public string Material_ElectricalFruit_Caption { get; set; }
        public string Material_FireFruit { get; set; }
        public string Material_FireFruit_Caption { get; set; }
        public string Material_FldObj_Pinecone_A_01 { get; set; }
        public string Material_FldObj_Pinecone_A_01_Caption { get; set; }
        public string Material_IceFruit { get; set; }
        public string Material_IceFruit_Caption { get; set; }
        public string Material_Item_Enemy_01 { get; set; }
        public string Material_Item_Enemy_01_Caption { get; set; }
        public string Material_Item_Enemy_02 { get; set; }
        public string Material_Item_Enemy_02_Caption { get; set; }
        public string Material_Item_Enemy_04 { get; set; }
        public string Material_Item_Enemy_04_Caption { get; set; }
        public string Material_Item_Enemy_05 { get; set; }
        public string Material_Item_Enemy_05_Caption { get; set; }
        public string Material_Item_Enemy_07 { get; set; }
        public string Material_Item_Enemy_07_Caption { get; set; }
        public string Material_Item_Enemy_08 { get; set; }
        public string Material_Item_Enemy_08_Caption { get; set; }
        public string Material_Item_Enemy_100 { get; set; }
        public string Material_Item_Enemy_100_Caption { get; set; }
        public string Material_Item_Enemy_101 { get; set; }
        public string Material_Item_Enemy_101_Caption { get; set; }
        public string Material_Item_Enemy_102 { get; set; }
        public string Material_Item_Enemy_102_Caption { get; set; }
        public string Material_Item_Enemy_103 { get; set; }
        public string Material_Item_Enemy_103_Caption { get; set; }
        public string Material_Item_Enemy_104 { get; set; }
        public string Material_Item_Enemy_104_Caption { get; set; }
        public string Material_Item_Enemy_105 { get; set; }
        public string Material_Item_Enemy_105_Caption { get; set; }
        public string Material_Item_Enemy_106 { get; set; }
        public string Material_Item_Enemy_106_Caption { get; set; }
        public string Material_Item_Enemy_107 { get; set; }
        public string Material_Item_Enemy_107_Caption { get; set; }
        public string Material_Item_Enemy_108 { get; set; }
        public string Material_Item_Enemy_108_Caption { get; set; }
        public string Material_Item_Enemy_109 { get; set; }
        public string Material_Item_Enemy_109_Caption { get; set; }
        public string Material_Item_Enemy_114 { get; set; }
        public string Material_Item_Enemy_114_Caption { get; set; }
        public string Material_Item_Enemy_115 { get; set; }
        public string Material_Item_Enemy_115_Caption { get; set; }
        public string Material_Item_Enemy_116 { get; set; }
        public string Material_Item_Enemy_116_Caption { get; set; }
        public string Material_Item_Enemy_117 { get; set; }
        public string Material_Item_Enemy_117_Caption { get; set; }
        public string Material_Item_Enemy_118 { get; set; }
        public string Material_Item_Enemy_118_Caption { get; set; }
        public string Material_Item_Enemy_119 { get; set; }
        public string Material_Item_Enemy_119_Caption { get; set; }
        public string Material_Item_Enemy_121 { get; set; }
        public string Material_Item_Enemy_121_Caption { get; set; }
        public string Material_Item_Enemy_123 { get; set; }
        public string Material_Item_Enemy_123_Caption { get; set; }
        public string Material_Item_Enemy_124 { get; set; }
        public string Material_Item_Enemy_124_Caption { get; set; }
        public string Material_Item_Enemy_13 { get; set; }
        public string Material_Item_Enemy_13_Caption { get; set; }
        public string Material_Item_Enemy_130 { get; set; }
        public string Material_Item_Enemy_130_Caption { get; set; }
        public string Material_Item_Enemy_131 { get; set; }
        public string Material_Item_Enemy_131_Caption { get; set; }
        public string Material_Item_Enemy_132 { get; set; }
        public string Material_Item_Enemy_132_Caption { get; set; }
        public string Material_Item_Enemy_133 { get; set; }
        public string Material_Item_Enemy_133_Caption { get; set; }
        public string Material_Item_Enemy_134 { get; set; }
        public string Material_Item_Enemy_134_Caption { get; set; }
        public string Material_Item_Enemy_135 { get; set; }
        public string Material_Item_Enemy_135_Caption { get; set; }
        public string Material_Item_Enemy_136 { get; set; }
        public string Material_Item_Enemy_136_Caption { get; set; }
        public string Material_Item_Enemy_14 { get; set; }
        public string Material_Item_Enemy_14_Caption { get; set; }
        public string Material_Item_Enemy_142 { get; set; }
        public string Material_Item_Enemy_142_Caption { get; set; }
        public string Material_Item_Enemy_143 { get; set; }
        public string Material_Item_Enemy_143_Caption { get; set; }
        public string Material_Item_Enemy_144 { get; set; }
        public string Material_Item_Enemy_144_Caption { get; set; }
        public string Material_Item_Enemy_148 { get; set; }
        public string Material_Item_Enemy_148_Caption { get; set; }
        public string Material_Item_Enemy_149 { get; set; }
        public string Material_Item_Enemy_149_Caption { get; set; }
        public string Material_Item_Enemy_15 { get; set; }
        public string Material_Item_Enemy_15_Caption { get; set; }
        public string Material_Item_Enemy_150 { get; set; }
        public string Material_Item_Enemy_150_Caption { get; set; }
        public string Material_Item_Enemy_151 { get; set; }
        public string Material_Item_Enemy_151_Caption { get; set; }
        public string Material_Item_Enemy_153 { get; set; }
        public string Material_Item_Enemy_153_Caption { get; set; }
        public string Material_Item_Enemy_154 { get; set; }
        public string Material_Item_Enemy_154_Caption { get; set; }
        public string Material_Item_Enemy_155 { get; set; }
        public string Material_Item_Enemy_155_Caption { get; set; }
        public string Material_Item_Enemy_156 { get; set; }
        public string Material_Item_Enemy_156_Caption { get; set; }
        public string Material_Item_Enemy_157 { get; set; }
        public string Material_Item_Enemy_157_Caption { get; set; }
        public string Material_Item_Enemy_158 { get; set; }
        public string Material_Item_Enemy_158_Caption { get; set; }
        public string Material_Item_Enemy_159 { get; set; }
        public string Material_Item_Enemy_159_Caption { get; set; }
        public string Material_Item_Enemy_16 { get; set; }
        public string Material_Item_Enemy_16_Caption { get; set; }
        public string Material_Item_Enemy_160 { get; set; }
        public string Material_Item_Enemy_160_Caption { get; set; }
        public string Material_Item_Enemy_166 { get; set; }
        public string Material_Item_Enemy_166_Caption { get; set; }
        public string Material_Item_Enemy_167 { get; set; }
        public string Material_Item_Enemy_167_Caption { get; set; }
        public string Material_Item_Enemy_168 { get; set; }
        public string Material_Item_Enemy_168_Caption { get; set; }
        public string Material_Item_Enemy_169 { get; set; }
        public string Material_Item_Enemy_169_Caption { get; set; }
        public string Material_Item_Enemy_17 { get; set; }
        public string Material_Item_Enemy_17_Caption { get; set; }
        public string Material_Item_Enemy_18 { get; set; }
        public string Material_Item_Enemy_18_Caption { get; set; }
        public string Material_Item_Enemy_181 { get; set; }
        public string Material_Item_Enemy_181_Caption { get; set; }
        public string Material_Item_Enemy_182 { get; set; }
        public string Material_Item_Enemy_182_Caption { get; set; }
        public string Material_Item_Enemy_183 { get; set; }
        public string Material_Item_Enemy_183_Caption { get; set; }
        public string Material_Item_Enemy_184 { get; set; }
        public string Material_Item_Enemy_184_Caption { get; set; }
        public string Material_Item_Enemy_186 { get; set; }
        public string Material_Item_Enemy_186_Caption { get; set; }
        public string Material_Item_Enemy_187 { get; set; }
        public string Material_Item_Enemy_187_Caption { get; set; }
        public string Material_Item_Enemy_188 { get; set; }
        public string Material_Item_Enemy_188_Caption { get; set; }
        public string Material_Item_Enemy_189 { get; set; }
        public string Material_Item_Enemy_189_Caption { get; set; }
        public string Material_Item_Enemy_19 { get; set; }
        public string Material_Item_Enemy_19_Caption { get; set; }
        public string Material_Item_Enemy_190 { get; set; }
        public string Material_Item_Enemy_190_Caption { get; set; }
        public string Material_Item_Enemy_191 { get; set; }
        public string Material_Item_Enemy_191_Caption { get; set; }
        public string Material_Item_Enemy_192 { get; set; }
        public string Material_Item_Enemy_192_Caption { get; set; }
        public string Material_Item_Enemy_193 { get; set; }
        public string Material_Item_Enemy_193_Caption { get; set; }
        public string Material_Item_Enemy_20 { get; set; }
        public string Material_Item_Enemy_20_Caption { get; set; }
        public string Material_Item_Enemy_208 { get; set; }
        public string Material_Item_Enemy_208_Caption { get; set; }
        public string Material_Item_Enemy_21 { get; set; }
        public string Material_Item_Enemy_21_Caption { get; set; }
        public string Material_Item_Enemy_210 { get; set; }
        public string Material_Item_Enemy_210_Caption { get; set; }
        public string Material_Item_Enemy_211 { get; set; }
        public string Material_Item_Enemy_211_Caption { get; set; }
        public string Material_Item_Enemy_212 { get; set; }
        public string Material_Item_Enemy_212_Caption { get; set; }
        public string Material_Item_Enemy_213 { get; set; }
        public string Material_Item_Enemy_213_Caption { get; set; }
        public string Material_Item_Enemy_214 { get; set; }
        public string Material_Item_Enemy_214_Caption { get; set; }
        public string Material_Item_Enemy_215 { get; set; }
        public string Material_Item_Enemy_215_Caption { get; set; }
        public string Material_Item_Enemy_216 { get; set; }
        public string Material_Item_Enemy_216_Caption { get; set; }
        public string Material_Item_Enemy_217 { get; set; }
        public string Material_Item_Enemy_217_Caption { get; set; }
        public string Material_Item_Enemy_218 { get; set; }
        public string Material_Item_Enemy_218_Caption { get; set; }
        public string Material_Item_Enemy_228 { get; set; }
        public string Material_Item_Enemy_228_Caption { get; set; }
        public string Material_Item_Enemy_229 { get; set; }
        public string Material_Item_Enemy_229_Caption { get; set; }
        public string Material_Item_Enemy_230 { get; set; }
        public string Material_Item_Enemy_230_Caption { get; set; }
        public string Material_Item_Enemy_231 { get; set; }
        public string Material_Item_Enemy_231_Caption { get; set; }
        public string Material_Item_Enemy_24 { get; set; }
        public string Material_Item_Enemy_24_Caption { get; set; }
        public string Material_Item_Enemy_25 { get; set; }
        public string Material_Item_Enemy_25_Caption { get; set; }
        public string Material_Item_Enemy_32 { get; set; }
        public string Material_Item_Enemy_32_Caption { get; set; }
        public string Material_Item_Enemy_33 { get; set; }
        public string Material_Item_Enemy_33_Caption { get; set; }
        public string Material_Item_Enemy_34 { get; set; }
        public string Material_Item_Enemy_34_Caption { get; set; }
        public string Material_Item_Enemy_38 { get; set; }
        public string Material_Item_Enemy_38_Caption { get; set; }
        public string Material_Item_Enemy_39 { get; set; }
        public string Material_Item_Enemy_39_Caption { get; set; }
        public string Material_Item_Enemy_40 { get; set; }
        public string Material_Item_Enemy_40_Caption { get; set; }
        public string Material_Item_Enemy_41 { get; set; }
        public string Material_Item_Enemy_41_Caption { get; set; }
        public string Material_Item_Enemy_42 { get; set; }
        public string Material_Item_Enemy_42_Caption { get; set; }
        public string Material_Item_Enemy_43 { get; set; }
        public string Material_Item_Enemy_43_Caption { get; set; }
        public string Material_Item_Enemy_44 { get; set; }
        public string Material_Item_Enemy_44_Caption { get; set; }
        public string Material_Item_Enemy_45 { get; set; }
        public string Material_Item_Enemy_45_Caption { get; set; }
        public string Material_Item_Enemy_46 { get; set; }
        public string Material_Item_Enemy_46_Caption { get; set; }
        public string Material_Item_Enemy_47 { get; set; }
        public string Material_Item_Enemy_47_Caption { get; set; }
        public string Material_Item_Enemy_49 { get; set; }
        public string Material_Item_Enemy_49_Caption { get; set; }
        public string Material_Item_Enemy_50 { get; set; }
        public string Material_Item_Enemy_50_Caption { get; set; }
        public string Material_Item_Enemy_51 { get; set; }
        public string Material_Item_Enemy_51_Caption { get; set; }
        public string Material_Item_Enemy_53 { get; set; }
        public string Material_Item_Enemy_53_Caption { get; set; }
        public string Material_Item_Enemy_54 { get; set; }
        public string Material_Item_Enemy_54_Caption { get; set; }
        public string Material_Item_Enemy_55 { get; set; }
        public string Material_Item_Enemy_55_Caption { get; set; }
        public string Material_Item_Enemy_57 { get; set; }
        public string Material_Item_Enemy_57_Caption { get; set; }
        public string Material_Item_Enemy_58 { get; set; }
        public string Material_Item_Enemy_58_Caption { get; set; }
        public string Material_Item_Enemy_59 { get; set; }
        public string Material_Item_Enemy_59_Caption { get; set; }
        public string Material_Item_Enemy_60 { get; set; }
        public string Material_Item_Enemy_60_Caption { get; set; }
        public string Material_Item_Enemy_64 { get; set; }
        public string Material_Item_Enemy_64_Caption { get; set; }
        public string Material_Item_Enemy_66 { get; set; }
        public string Material_Item_Enemy_66_Caption { get; set; }
        public string Material_Item_Enemy_67 { get; set; }
        public string Material_Item_Enemy_67_Caption { get; set; }
        public string Material_Item_Enemy_69 { get; set; }
        public string Material_Item_Enemy_69_Caption { get; set; }
        public string Material_Item_Enemy_77 { get; set; }
        public string Material_Item_Enemy_77_Caption { get; set; }
        public string Material_Item_Enemy_78 { get; set; }
        public string Material_Item_Enemy_78_Caption { get; set; }
        public string Material_Item_Enemy_79 { get; set; }
        public string Material_Item_Enemy_79_Caption { get; set; }
        public string Material_Item_Enemy_80 { get; set; }
        public string Material_Item_Enemy_80_Caption { get; set; }
        public string Material_Item_Enemy_89 { get; set; }
        public string Material_Item_Enemy_89_Caption { get; set; }
        public string Material_Item_Enemy_90 { get; set; }
        public string Material_Item_Enemy_90_Caption { get; set; }
        public string Material_Item_Enemy_91 { get; set; }
        public string Material_Item_Enemy_91_Caption { get; set; }
        public string Material_Item_Enemy_92 { get; set; }
        public string Material_Item_Enemy_92_Caption { get; set; }
        public string Material_Item_FishGet_A { get; set; }
        public string Material_Item_FishGet_A_Caption { get; set; }
        public string Material_Item_FishGet_AA { get; set; }
        public string Material_Item_FishGet_AA_Caption { get; set; }
        public string Material_Item_FishGet_AC { get; set; }
        public string Material_Item_FishGet_AC_Caption { get; set; }
        public string Material_Item_FishGet_B { get; set; }
        public string Material_Item_FishGet_B_Caption { get; set; }
        public string Material_Item_FishGet_C { get; set; }
        public string Material_Item_FishGet_C_Caption { get; set; }
        public string Material_Item_FishGet_D { get; set; }
        public string Material_Item_FishGet_D_Caption { get; set; }
        public string Material_Item_FishGet_E { get; set; }
        public string Material_Item_FishGet_E_Caption { get; set; }
        public string Material_Item_FishGet_F { get; set; }
        public string Material_Item_FishGet_F_Caption { get; set; }
        public string Material_Item_FishGet_G { get; set; }
        public string Material_Item_FishGet_G_Caption { get; set; }
        public string Material_Item_FishGet_H { get; set; }
        public string Material_Item_FishGet_H_Caption { get; set; }
        public string Material_Item_FishGet_I { get; set; }
        public string Material_Item_FishGet_I_Caption { get; set; }
        public string Material_Item_FishGet_J { get; set; }
        public string Material_Item_FishGet_J_Caption { get; set; }
        public string Material_Item_FishGet_L { get; set; }
        public string Material_Item_FishGet_L_Caption { get; set; }
        public string Material_Item_FishGet_M { get; set; }
        public string Material_Item_FishGet_M_Caption { get; set; }
        public string Material_Item_FishGet_X { get; set; }
        public string Material_Item_FishGet_X_Caption { get; set; }
        public string Material_Item_FishGet_Z { get; set; }
        public string Material_Item_FishGet_Z_Caption { get; set; }
        public string Material_Item_Fruit_A { get; set; }
        public string Material_Item_Fruit_A_Caption { get; set; }
        public string Material_Item_Fruit_B { get; set; }
        public string Material_Item_Fruit_B_Caption { get; set; }
        public string Material_Item_Fruit_C { get; set; }
        public string Material_Item_Fruit_C_Caption { get; set; }
        public string Material_Item_Fruit_E { get; set; }
        public string Material_Item_Fruit_E_Caption { get; set; }
        public string Material_Item_Fruit_F { get; set; }
        public string Material_Item_Fruit_F_Caption { get; set; }
        public string Material_Item_Fruit_G { get; set; }
        public string Material_Item_Fruit_G_Caption { get; set; }
        public string Material_Item_Fruit_H { get; set; }
        public string Material_Item_Fruit_H_Caption { get; set; }
        public string Material_Item_Fruit_I { get; set; }
        public string Material_Item_Fruit_I_Caption { get; set; }
        public string Material_Item_Fruit_J { get; set; }
        public string Material_Item_Fruit_J_Caption { get; set; }
        public string Material_Item_Fruit_K { get; set; }
        public string Material_Item_Fruit_K_Caption { get; set; }
        public string Material_Item_Fruit_L { get; set; }
        public string Material_Item_Fruit_L_Caption { get; set; }
        public string Material_Item_Fruit_M { get; set; }
        public string Material_Item_Fruit_M_Caption { get; set; }
        public string Material_Item_Fruit_N { get; set; }
        public string Material_Item_Fruit_N_Caption { get; set; }
        public string Material_Item_Fruit_P { get; set; }
        public string Material_Item_Fruit_P_Caption { get; set; }
        public string Material_Item_InsectGet_K { get; set; }
        public string Material_Item_InsectGet_K_Caption { get; set; }
        public string Material_Item_InsectGet_O { get; set; }
        public string Material_Item_InsectGet_O_Caption { get; set; }
        public string Material_Item_InsectGet_Z { get; set; }
        public string Material_Item_InsectGet_Z_Caption { get; set; }
        public string Material_Item_KingScale { get; set; }
        public string Material_Item_KingScale_Caption { get; set; }
        public string Material_Item_Material_01 { get; set; }
        public string Material_Item_Material_01_Caption { get; set; }
        public string Material_Item_Material_02 { get; set; }
        public string Material_Item_Material_02_Caption { get; set; }
        public string Material_Item_Material_03 { get; set; }
        public string Material_Item_Material_03_Caption { get; set; }
        public string Material_Item_Material_04 { get; set; }
        public string Material_Item_Material_04_Caption { get; set; }
        public string Material_Item_Material_05 { get; set; }
        public string Material_Item_Material_05_Caption { get; set; }
        public string Material_Item_Material_06 { get; set; }
        public string Material_Item_Material_06_Caption { get; set; }
        public string Material_Item_Material_07 { get; set; }
        public string Material_Item_Material_07_Caption { get; set; }
        public string Material_Item_Material_08 { get; set; }
        public string Material_Item_Material_08_Caption { get; set; }
        public string Material_Item_Material_09 { get; set; }
        public string Material_Item_Material_09_Caption { get; set; }
        public string Material_Item_Material_10 { get; set; }
        public string Material_Item_Material_10_Caption { get; set; }
        public string Material_Item_Material_11 { get; set; }
        public string Material_Item_Material_11_Caption { get; set; }
        public string Material_Item_Meat_01 { get; set; }
        public string Material_Item_Meat_01_Caption { get; set; }
        public string Material_Item_Meat_02 { get; set; }
        public string Material_Item_Meat_02_Caption { get; set; }
        public string Material_Item_Meat_06 { get; set; }
        public string Material_Item_Meat_06_Caption { get; set; }
        public string Material_Item_Meat_07 { get; set; }
        public string Material_Item_Meat_07_Caption { get; set; }
        public string Material_Item_Meat_11 { get; set; }
        public string Material_Item_Meat_11_Caption { get; set; }
        public string Material_Item_Meat_12 { get; set; }
        public string Material_Item_Meat_12_Caption { get; set; }
        public string Material_Item_MushroomGet_D { get; set; }
        public string Material_Item_MushroomGet_D_Caption { get; set; }
        public string Material_Item_MushroomGet_K { get; set; }
        public string Material_Item_MushroomGet_K_Caption { get; set; }
        public string Material_Item_Mushroom_A { get; set; }
        public string Material_Item_Mushroom_A_Caption { get; set; }
        public string Material_Item_Mushroom_B { get; set; }
        public string Material_Item_Mushroom_B_Caption { get; set; }
        public string Material_Item_Mushroom_C { get; set; }
        public string Material_Item_Mushroom_C_Caption { get; set; }
        public string Material_Item_Mushroom_E { get; set; }
        public string Material_Item_Mushroom_E_Caption { get; set; }
        public string Material_Item_Mushroom_F { get; set; }
        public string Material_Item_Mushroom_F_Caption { get; set; }
        public string Material_Item_Mushroom_H { get; set; }
        public string Material_Item_Mushroom_H_Caption { get; set; }
        public string Material_Item_Mushroom_J { get; set; }
        public string Material_Item_Mushroom_J_Caption { get; set; }
        public string Material_Item_Mushroom_L { get; set; }
        public string Material_Item_Mushroom_L_Caption { get; set; }
        public string Material_Item_Mushroom_M { get; set; }
        public string Material_Item_Mushroom_M_Caption { get; set; }
        public string Material_Item_Mushroom_N { get; set; }
        public string Material_Item_Mushroom_N_Caption { get; set; }
        public string Material_Item_Mushroom_O { get; set; }
        public string Material_Item_Mushroom_O_Caption { get; set; }
        public string Material_Item_Mushroom_P { get; set; }
        public string Material_Item_Mushroom_P_Caption { get; set; }
        public string Material_Item_Ore_A { get; set; }
        public string Material_Item_Ore_A_Caption { get; set; }
        public string Material_Item_Ore_B { get; set; }
        public string Material_Item_Ore_B_Caption { get; set; }
        public string Material_Item_Ore_C { get; set; }
        public string Material_Item_Ore_C_Caption { get; set; }
        public string Material_Item_Ore_D { get; set; }
        public string Material_Item_Ore_D_Caption { get; set; }
        public string Material_Item_Ore_E { get; set; }
        public string Material_Item_Ore_E_Caption { get; set; }
        public string Material_Item_Ore_F { get; set; }
        public string Material_Item_Ore_F_Caption { get; set; }
        public string Material_Item_Ore_G { get; set; }
        public string Material_Item_Ore_G_Caption { get; set; }
        public string Material_Item_Ore_H { get; set; }
        public string Material_Item_Ore_H_Caption { get; set; }
        public string Material_Item_Ore_I { get; set; }
        public string Material_Item_Ore_I_Caption { get; set; }
        public string Material_Item_Ore_J { get; set; }
        public string Material_Item_Ore_J_Caption { get; set; }
        public string Material_Item_Ore_L { get; set; }
        public string Material_Item_Ore_L_Caption { get; set; }
        public string Material_Item_Ore_M { get; set; }
        public string Material_Item_Ore_M_Caption { get; set; }
        public string Material_Item_PlantGet_A { get; set; }
        public string Material_Item_PlantGet_A_Caption { get; set; }
        public string Material_Item_PlantGet_B { get; set; }
        public string Material_Item_PlantGet_B_Caption { get; set; }
        public string Material_Item_PlantGet_C { get; set; }
        public string Material_Item_PlantGet_C_Caption { get; set; }
        public string Material_Item_PlantGet_E { get; set; }
        public string Material_Item_PlantGet_E_Caption { get; set; }
        public string Material_Item_PlantGet_F { get; set; }
        public string Material_Item_PlantGet_F_Caption { get; set; }
        public string Material_Item_PlantGet_G { get; set; }
        public string Material_Item_PlantGet_G_Caption { get; set; }
        public string Material_Item_PlantGet_H { get; set; }
        public string Material_Item_PlantGet_H_Caption { get; set; }
        public string Material_Item_PlantGet_I { get; set; }
        public string Material_Item_PlantGet_I_Caption { get; set; }
        public string Material_Item_PlantGet_J { get; set; }
        public string Material_Item_PlantGet_J_Caption { get; set; }
        public string Material_Item_PlantGet_L { get; set; }
        public string Material_Item_PlantGet_L_Caption { get; set; }
        public string Material_Item_PlantGet_M { get; set; }
        public string Material_Item_PlantGet_M_Caption { get; set; }
        public string Material_Item_PlantGet_O { get; set; }
        public string Material_Item_PlantGet_O_Caption { get; set; }
        public string Material_Item_PlantGet_Q { get; set; }
        public string Material_Item_PlantGet_Q_Caption { get; set; }
        public string Material_Item_PlantGet_R { get; set; }
        public string Material_Item_PlantGet_R_Caption { get; set; }
        public string Material_Item_PlantGet_S { get; set; }
        public string Material_Item_PlantGet_S_Caption { get; set; }
        public string Material_Item_PlantGet_U { get; set; }
        public string Material_Item_PlantGet_U_Caption { get; set; }
        public string Material_Item_Weapon_01 { get; set; }
        public string Material_Item_Weapon_01_Caption { get; set; }
        public string Material_LightBall_Large { get; set; }
        public string Material_LightBall_Large_Caption { get; set; }
        public string Material_LightBall_Small { get; set; }
        public string Material_LightBall_Small_Caption { get; set; }
        public string Material_LightFruit { get; set; }
        public string Material_LightFruit_Caption { get; set; }
        public string Material_Obj_FireWoodBundle { get; set; }
        public string Material_Obj_FireWoodBundle_Caption { get; set; }
        public string Material_SmokeFruit { get; set; }
        public string Material_SmokeFruit_Caption { get; set; }
        public string Material_WaterFruit { get; set; }
        public string Material_WaterFruit_Caption { get; set; }
        public string Meal_Item_Boiled_01 { get; set; }
        public string Meal_Item_Boiled_01_Caption { get; set; }
        public string Meal_Item_ChilledFish_01 { get; set; }
        public string Meal_Item_ChilledFish_01_Caption { get; set; }
        public string Meal_Item_ChilledFish_02 { get; set; }
        public string Meal_Item_ChilledFish_02_Caption { get; set; }
        public string Meal_Item_ChilledFish_03 { get; set; }
        public string Meal_Item_ChilledFish_03_Caption { get; set; }
        public string Meal_Item_ChilledFish_04 { get; set; }
        public string Meal_Item_ChilledFish_04_Caption { get; set; }
        public string Meal_Item_ChilledFish_05 { get; set; }
        public string Meal_Item_ChilledFish_05_Caption { get; set; }
        public string Meal_Item_ChilledFish_06 { get; set; }
        public string Meal_Item_ChilledFish_06_Caption { get; set; }
        public string Meal_Item_ChilledFish_07 { get; set; }
        public string Meal_Item_ChilledFish_07_Caption { get; set; }
        public string Meal_Item_ChilledFish_08 { get; set; }
        public string Meal_Item_ChilledFish_08_Caption { get; set; }
        public string Meal_Item_ChilledFish_16 { get; set; }
        public string Meal_Item_ChilledFish_16_Caption { get; set; }
        public string Meal_Item_ChilledFish_18 { get; set; }
        public string Meal_Item_ChilledFish_18_Caption { get; set; }
        public string Meal_Item_Chilled_01 { get; set; }
        public string Meal_Item_Chilled_01_Caption { get; set; }
        public string Meal_Item_Chilled_02 { get; set; }
        public string Meal_Item_Chilled_02_Caption { get; set; }
        public string Meal_Item_Chilled_03 { get; set; }
        public string Meal_Item_Chilled_03_Caption { get; set; }
        public string Meal_Item_Chilled_04 { get; set; }
        public string Meal_Item_Chilled_04_Caption { get; set; }
        public string Meal_Item_Chilled_05 { get; set; }
        public string Meal_Item_Chilled_05_Caption { get; set; }
        public string Meal_Item_Chilled_06 { get; set; }
        public string Meal_Item_Chilled_06_Caption { get; set; }
        public string Meal_Item_Cook_A_01 { get; set; }
        public string Meal_Item_Cook_A_01_Caption { get; set; }
        public string Meal_Item_Cook_A_02 { get; set; }
        public string Meal_Item_Cook_A_02_Caption { get; set; }
        public string Meal_Item_Cook_A_03 { get; set; }
        public string Meal_Item_Cook_A_03_Caption { get; set; }
        public string Meal_Item_Cook_A_04 { get; set; }
        public string Meal_Item_Cook_A_04_Caption { get; set; }
        public string Meal_Item_Cook_A_05 { get; set; }
        public string Meal_Item_Cook_A_05_Caption { get; set; }
        public string Meal_Item_Cook_A_07 { get; set; }
        public string Meal_Item_Cook_A_07_Caption { get; set; }
        public string Meal_Item_Cook_A_08 { get; set; }
        public string Meal_Item_Cook_A_08_Caption { get; set; }
        public string Meal_Item_Cook_A_09 { get; set; }
        public string Meal_Item_Cook_A_09_Caption { get; set; }
        public string Meal_Item_Cook_A_10 { get; set; }
        public string Meal_Item_Cook_A_10_Caption { get; set; }
        public string Meal_Item_Cook_A_11 { get; set; }
        public string Meal_Item_Cook_A_11_Caption { get; set; }
        public string Meal_Item_Cook_A_12 { get; set; }
        public string Meal_Item_Cook_A_12_Caption { get; set; }
        public string Meal_Item_Cook_A_13 { get; set; }
        public string Meal_Item_Cook_A_13_Caption { get; set; }
        public string Meal_Item_Cook_A_14 { get; set; }
        public string Meal_Item_Cook_A_14_Caption { get; set; }
        public string Meal_Item_Cook_B_01 { get; set; }
        public string Meal_Item_Cook_B_01_Caption { get; set; }
        public string Meal_Item_Cook_B_02 { get; set; }
        public string Meal_Item_Cook_B_02_Caption { get; set; }
        public string Meal_Item_Cook_B_05 { get; set; }
        public string Meal_Item_Cook_B_05_Caption { get; set; }
        public string Meal_Item_Cook_B_06 { get; set; }
        public string Meal_Item_Cook_B_06_Caption { get; set; }
        public string Meal_Item_Cook_B_11 { get; set; }
        public string Meal_Item_Cook_B_11_Caption { get; set; }
        public string Meal_Item_Cook_B_12 { get; set; }
        public string Meal_Item_Cook_B_12_Caption { get; set; }
        public string Meal_Item_Cook_B_13 { get; set; }
        public string Meal_Item_Cook_B_13_Caption { get; set; }
        public string Meal_Item_Cook_B_15 { get; set; }
        public string Meal_Item_Cook_B_15_Caption { get; set; }
        public string Meal_Item_Cook_B_16 { get; set; }
        public string Meal_Item_Cook_B_16_Caption { get; set; }
        public string Meal_Item_Cook_B_17 { get; set; }
        public string Meal_Item_Cook_B_17_Caption { get; set; }
        public string Meal_Item_Cook_B_18 { get; set; }
        public string Meal_Item_Cook_B_18_Caption { get; set; }
        public string Meal_Item_Cook_B_19 { get; set; }
        public string Meal_Item_Cook_B_19_Caption { get; set; }
        public string Meal_Item_Cook_B_20 { get; set; }
        public string Meal_Item_Cook_B_20_Caption { get; set; }
        public string Meal_Item_Cook_B_21 { get; set; }
        public string Meal_Item_Cook_B_21_Caption { get; set; }
        public string Meal_Item_Cook_B_22 { get; set; }
        public string Meal_Item_Cook_B_22_Caption { get; set; }
        public string Meal_Item_Cook_B_23 { get; set; }
        public string Meal_Item_Cook_B_23_Caption { get; set; }
        public string Meal_Item_Cook_C_16 { get; set; }
        public string Meal_Item_Cook_C_16_Caption { get; set; }
        public string Meal_Item_Cook_C_17 { get; set; }
        public string Meal_Item_Cook_C_17_Caption { get; set; }
        public string Meal_Item_Cook_D_01 { get; set; }
        public string Meal_Item_Cook_D_01_Caption { get; set; }
        public string Meal_Item_Cook_D_02 { get; set; }
        public string Meal_Item_Cook_D_02_Caption { get; set; }
        public string Meal_Item_Cook_D_03 { get; set; }
        public string Meal_Item_Cook_D_03_Caption { get; set; }
        public string Meal_Item_Cook_D_04 { get; set; }
        public string Meal_Item_Cook_D_04_Caption { get; set; }
        public string Meal_Item_Cook_D_05 { get; set; }
        public string Meal_Item_Cook_D_05_Caption { get; set; }
        public string Meal_Item_Cook_D_06 { get; set; }
        public string Meal_Item_Cook_D_06_Caption { get; set; }
        public string Meal_Item_Cook_D_07 { get; set; }
        public string Meal_Item_Cook_D_07_Caption { get; set; }
        public string Meal_Item_Cook_D_08 { get; set; }
        public string Meal_Item_Cook_D_08_Caption { get; set; }
        public string Meal_Item_Cook_D_09 { get; set; }
        public string Meal_Item_Cook_D_09_Caption { get; set; }
        public string Meal_Item_Cook_D_10 { get; set; }
        public string Meal_Item_Cook_D_10_Caption { get; set; }
        public string Meal_Item_Cook_E_01 { get; set; }
        public string Meal_Item_Cook_E_01_Caption { get; set; }
        public string Meal_Item_Cook_E_02 { get; set; }
        public string Meal_Item_Cook_E_02_Caption { get; set; }
        public string Meal_Item_Cook_E_03 { get; set; }
        public string Meal_Item_Cook_E_03_Caption { get; set; }
        public string Meal_Item_Cook_E_04 { get; set; }
        public string Meal_Item_Cook_E_04_Caption { get; set; }
        public string Meal_Item_Cook_F_01 { get; set; }
        public string Meal_Item_Cook_F_01_Caption { get; set; }
        public string Meal_Item_Cook_F_02 { get; set; }
        public string Meal_Item_Cook_F_02_Caption { get; set; }
        public string Meal_Item_Cook_F_03 { get; set; }
        public string Meal_Item_Cook_F_03_Caption { get; set; }
        public string Meal_Item_Cook_F_04 { get; set; }
        public string Meal_Item_Cook_F_04_Caption { get; set; }
        public string Meal_Item_Cook_G_02 { get; set; }
        public string Meal_Item_Cook_G_02_Caption { get; set; }
        public string Meal_Item_Cook_G_03 { get; set; }
        public string Meal_Item_Cook_G_03_Caption { get; set; }
        public string Meal_Item_Cook_G_04 { get; set; }
        public string Meal_Item_Cook_G_04_Caption { get; set; }
        public string Meal_Item_Cook_G_05 { get; set; }
        public string Meal_Item_Cook_G_05_Caption { get; set; }
        public string Meal_Item_Cook_G_06 { get; set; }
        public string Meal_Item_Cook_G_06_Caption { get; set; }
        public string Meal_Item_Cook_G_09 { get; set; }
        public string Meal_Item_Cook_G_09_Caption { get; set; }
        public string Meal_Item_Cook_G_10 { get; set; }
        public string Meal_Item_Cook_G_10_Caption { get; set; }
        public string Meal_Item_Cook_G_11 { get; set; }
        public string Meal_Item_Cook_G_11_Caption { get; set; }
        public string Meal_Item_Cook_G_12 { get; set; }
        public string Meal_Item_Cook_G_12_Caption { get; set; }
        public string Meal_Item_Cook_G_13 { get; set; }
        public string Meal_Item_Cook_G_13_Caption { get; set; }
        public string Meal_Item_Cook_G_14 { get; set; }
        public string Meal_Item_Cook_G_14_Caption { get; set; }
        public string Meal_Item_Cook_G_15 { get; set; }
        public string Meal_Item_Cook_G_15_Caption { get; set; }
        public string Meal_Item_Cook_G_16 { get; set; }
        public string Meal_Item_Cook_G_16_Caption { get; set; }
        public string Meal_Item_Cook_G_17 { get; set; }
        public string Meal_Item_Cook_G_17_Caption { get; set; }
        public string Meal_Item_Cook_H_01 { get; set; }
        public string Meal_Item_Cook_H_01_Caption { get; set; }
        public string Meal_Item_Cook_H_02 { get; set; }
        public string Meal_Item_Cook_H_02_Caption { get; set; }
        public string Meal_Item_Cook_H_03 { get; set; }
        public string Meal_Item_Cook_H_03_Caption { get; set; }
        public string Meal_Item_Cook_I_01 { get; set; }
        public string Meal_Item_Cook_I_01_Caption { get; set; }
        public string Meal_Item_Cook_I_02 { get; set; }
        public string Meal_Item_Cook_I_02_Caption { get; set; }
        public string Meal_Item_Cook_I_03 { get; set; }
        public string Meal_Item_Cook_I_03_Caption { get; set; }
        public string Meal_Item_Cook_I_04 { get; set; }
        public string Meal_Item_Cook_I_04_Caption { get; set; }
        public string Meal_Item_Cook_I_05 { get; set; }
        public string Meal_Item_Cook_I_05_Caption { get; set; }
        public string Meal_Item_Cook_I_06 { get; set; }
        public string Meal_Item_Cook_I_06_Caption { get; set; }
        public string Meal_Item_Cook_I_07 { get; set; }
        public string Meal_Item_Cook_I_07_Caption { get; set; }
        public string Meal_Item_Cook_I_08 { get; set; }
        public string Meal_Item_Cook_I_08_Caption { get; set; }
        public string Meal_Item_Cook_I_09 { get; set; }
        public string Meal_Item_Cook_I_09_Caption { get; set; }
        public string Meal_Item_Cook_I_10 { get; set; }
        public string Meal_Item_Cook_I_10_Caption { get; set; }
        public string Meal_Item_Cook_I_11 { get; set; }
        public string Meal_Item_Cook_I_11_Caption { get; set; }
        public string Meal_Item_Cook_I_12 { get; set; }
        public string Meal_Item_Cook_I_12_Caption { get; set; }
        public string Meal_Item_Cook_I_13 { get; set; }
        public string Meal_Item_Cook_I_13_Caption { get; set; }
        public string Meal_Item_Cook_I_14 { get; set; }
        public string Meal_Item_Cook_I_14_Caption { get; set; }
        public string Meal_Item_Cook_I_15 { get; set; }
        public string Meal_Item_Cook_I_15_Caption { get; set; }
        public string Meal_Item_Cook_I_16 { get; set; }
        public string Meal_Item_Cook_I_16_Caption { get; set; }
        public string Meal_Item_Cook_I_17 { get; set; }
        public string Meal_Item_Cook_I_17_Caption { get; set; }
        public string Meal_Item_Cook_J_01 { get; set; }
        public string Meal_Item_Cook_J_01_Caption { get; set; }
        public string Meal_Item_Cook_J_02 { get; set; }
        public string Meal_Item_Cook_J_02_Caption { get; set; }
        public string Meal_Item_Cook_J_03 { get; set; }
        public string Meal_Item_Cook_J_03_Caption { get; set; }
        public string Meal_Item_Cook_J_04 { get; set; }
        public string Meal_Item_Cook_J_04_Caption { get; set; }
        public string Meal_Item_Cook_J_05 { get; set; }
        public string Meal_Item_Cook_J_05_Caption { get; set; }
        public string Meal_Item_Cook_J_06 { get; set; }
        public string Meal_Item_Cook_J_06_Caption { get; set; }
        public string Meal_Item_Cook_J_07 { get; set; }
        public string Meal_Item_Cook_J_07_Caption { get; set; }
        public string Meal_Item_Cook_J_08 { get; set; }
        public string Meal_Item_Cook_J_08_Caption { get; set; }
        public string Meal_Item_Cook_J_09 { get; set; }
        public string Meal_Item_Cook_J_09_Caption { get; set; }
        public string Meal_Item_Cook_K_01 { get; set; }
        public string Meal_Item_Cook_K_01_Caption { get; set; }
        public string Meal_Item_Cook_K_02 { get; set; }
        public string Meal_Item_Cook_K_02_Caption { get; set; }
        public string Meal_Item_Cook_K_03 { get; set; }
        public string Meal_Item_Cook_K_03_Caption { get; set; }
        public string Meal_Item_Cook_K_04 { get; set; }
        public string Meal_Item_Cook_K_04_Caption { get; set; }
        public string Meal_Item_Cook_K_05 { get; set; }
        public string Meal_Item_Cook_K_05_Caption { get; set; }
        public string Meal_Item_Cook_K_06 { get; set; }
        public string Meal_Item_Cook_K_06_Caption { get; set; }
        public string Meal_Item_Cook_K_07 { get; set; }
        public string Meal_Item_Cook_K_07_Caption { get; set; }
        public string Meal_Item_Cook_K_08 { get; set; }
        public string Meal_Item_Cook_K_08_Caption { get; set; }
        public string Meal_Item_Cook_K_09 { get; set; }
        public string Meal_Item_Cook_K_09_Caption { get; set; }
        public string Meal_Item_Cook_L_01 { get; set; }
        public string Meal_Item_Cook_L_01_Caption { get; set; }
        public string Meal_Item_Cook_L_02 { get; set; }
        public string Meal_Item_Cook_L_02_Caption { get; set; }
        public string Meal_Item_Cook_L_03 { get; set; }
        public string Meal_Item_Cook_L_03_Caption { get; set; }
        public string Meal_Item_Cook_L_04 { get; set; }
        public string Meal_Item_Cook_L_04_Caption { get; set; }
        public string Meal_Item_Cook_L_05 { get; set; }
        public string Meal_Item_Cook_L_05_Caption { get; set; }
        public string Meal_Item_Cook_M_01 { get; set; }
        public string Meal_Item_Cook_M_01_Caption { get; set; }
        public string Meal_Item_Cook_N_01 { get; set; }
        public string Meal_Item_Cook_N_01_Caption { get; set; }
        public string Meal_Item_Cook_N_02 { get; set; }
        public string Meal_Item_Cook_N_02_Caption { get; set; }
        public string Meal_Item_Cook_N_03 { get; set; }
        public string Meal_Item_Cook_N_03_Caption { get; set; }
        public string Meal_Item_Cook_N_04 { get; set; }
        public string Meal_Item_Cook_N_04_Caption { get; set; }
        public string Meal_Item_Cook_O_01 { get; set; }
        public string Meal_Item_Cook_O_01_Caption { get; set; }
        public string Meal_Item_Cook_O_02 { get; set; }
        public string Meal_Item_Cook_O_02_Caption { get; set; }
        public string Meal_Item_Cook_P_01 { get; set; }
        public string Meal_Item_Cook_P_01_Caption { get; set; }
        public string Meal_Item_Cook_P_02 { get; set; }
        public string Meal_Item_Cook_P_02_Caption { get; set; }
        public string Meal_Item_Cook_P_03 { get; set; }
        public string Meal_Item_Cook_P_03_Caption { get; set; }
        public string Meal_Item_Cook_P_04 { get; set; }
        public string Meal_Item_Cook_P_04_Caption { get; set; }
        public string Meal_Item_Cook_P_05 { get; set; }
        public string Meal_Item_Cook_P_05_Caption { get; set; }
        public string Meal_Item_Cook_Q_01 { get; set; }
        public string Meal_Item_Cook_Q_01_Caption { get; set; }
        public string Meal_Item_Cook_Q_02 { get; set; }
        public string Meal_Item_Cook_Q_02_Caption { get; set; }
        public string Meal_Item_Cook_Q_03 { get; set; }
        public string Meal_Item_Cook_Q_03_Caption { get; set; }
        public string Meal_Item_Cook_Q_04 { get; set; }
        public string Meal_Item_Cook_Q_04_Caption { get; set; }
        public string Meal_Item_Cook_Q_05 { get; set; }
        public string Meal_Item_Cook_Q_05_Caption { get; set; }
        public string Meal_Item_Cook_Q_06 { get; set; }
        public string Meal_Item_Cook_Q_06_Caption { get; set; }
        public string Meal_Item_Cook_Q_07 { get; set; }
        public string Meal_Item_Cook_Q_07_Caption { get; set; }
        public string Meal_Item_Cook_Q_08 { get; set; }
        public string Meal_Item_Cook_Q_08_Caption { get; set; }
        public string Meal_Item_Cook_Q_09 { get; set; }
        public string Meal_Item_Cook_Q_09_Caption { get; set; }
        public string Meal_Item_Cook_Q_10 { get; set; }
        public string Meal_Item_Cook_Q_10_Caption { get; set; }
        public string Meal_Item_Cook_R_01 { get; set; }
        public string Meal_Item_Cook_R_01_Caption { get; set; }
        public string Meal_Item_Cook_R_02 { get; set; }
        public string Meal_Item_Cook_R_02_Caption { get; set; }
        public string Meal_Item_Cook_R_03 { get; set; }
        public string Meal_Item_Cook_R_03_Caption { get; set; }
        public string Meal_Item_Cook_R_04 { get; set; }
        public string Meal_Item_Cook_R_04_Caption { get; set; }
        public string Meal_Item_Cook_R_05 { get; set; }
        public string Meal_Item_Cook_R_05_Caption { get; set; }
        public string Meal_Item_Cook_R_06 { get; set; }
        public string Meal_Item_Cook_R_06_Caption { get; set; }
        public string Meal_Item_Cook_R_07 { get; set; }
        public string Meal_Item_Cook_R_07_Caption { get; set; }
        public string Meal_Item_Cook_R_08 { get; set; }
        public string Meal_Item_Cook_R_08_Caption { get; set; }
        public string Meal_Item_Cook_R_09 { get; set; }
        public string Meal_Item_Cook_R_09_Caption { get; set; }
        public string Meal_Item_Cook_R_10 { get; set; }
        public string Meal_Item_Cook_R_10_Caption { get; set; }
        public string Meal_Item_Cook_S_01 { get; set; }
        public string Meal_Item_Cook_S_01_Caption { get; set; }
        public string Meal_Item_Cook_S_02 { get; set; }
        public string Meal_Item_Cook_S_02_Caption { get; set; }
        public string Meal_Item_Cook_S_03 { get; set; }
        public string Meal_Item_Cook_S_03_Caption { get; set; }
        public string Meal_Item_Cook_S_04 { get; set; }
        public string Meal_Item_Cook_S_04_Caption { get; set; }
        public string Meal_Item_Cook_S_05 { get; set; }
        public string Meal_Item_Cook_S_05_Caption { get; set; }
        public string Meal_Item_Cook_S_06 { get; set; }
        public string Meal_Item_Cook_S_06_Caption { get; set; }
        public string Meal_Item_Cook_S_07 { get; set; }
        public string Meal_Item_Cook_S_07_Caption { get; set; }
        public string Meal_Item_Cook_S_08 { get; set; }
        public string Meal_Item_Cook_S_08_Caption { get; set; }
        public string Meal_Item_Cook_S_09 { get; set; }
        public string Meal_Item_Cook_S_09_Caption { get; set; }
        public string Meal_Item_Cook_S_10 { get; set; }
        public string Meal_Item_Cook_S_10_Caption { get; set; }
        public string Meal_Item_RoastFish_01 { get; set; }
        public string Meal_Item_RoastFish_01_Caption { get; set; }
        public string Meal_Item_RoastFish_02 { get; set; }
        public string Meal_Item_RoastFish_02_Caption { get; set; }
        public string Meal_Item_RoastFish_03 { get; set; }
        public string Meal_Item_RoastFish_03_Caption { get; set; }
        public string Meal_Item_RoastFish_04 { get; set; }
        public string Meal_Item_RoastFish_04_Caption { get; set; }
        public string Meal_Item_RoastFish_07 { get; set; }
        public string Meal_Item_RoastFish_07_Caption { get; set; }
        public string Meal_Item_RoastFish_09 { get; set; }
        public string Meal_Item_RoastFish_09_Caption { get; set; }
        public string Meal_Item_RoastFish_13 { get; set; }
        public string Meal_Item_RoastFish_13_Caption { get; set; }
        public string Meal_Item_RoastFish_15 { get; set; }
        public string Meal_Item_RoastFish_15_Caption { get; set; }
        public string Meal_Item_RoastFish_16 { get; set; }
        public string Meal_Item_RoastFish_16_Caption { get; set; }
        public string Meal_Item_RoastFish_18 { get; set; }
        public string Meal_Item_RoastFish_18_Caption { get; set; }
        public string Meal_Item_Roast_01 { get; set; }
        public string Meal_Item_Roast_01_Caption { get; set; }
        public string Meal_Item_Roast_02 { get; set; }
        public string Meal_Item_Roast_02_Caption { get; set; }
        public string Meal_Item_Roast_03 { get; set; }
        public string Meal_Item_Roast_03_Caption { get; set; }
        public string Meal_Item_Roast_04 { get; set; }
        public string Meal_Item_Roast_04_Caption { get; set; }
        public string Meal_Item_Roast_05 { get; set; }
        public string Meal_Item_Roast_05_Caption { get; set; }
        public string Meal_Item_Roast_06 { get; set; }
        public string Meal_Item_Roast_06_Caption { get; set; }
        public string Meal_Item_Roast_07 { get; set; }
        public string Meal_Item_Roast_07_Caption { get; set; }
        public string Meal_Item_Roast_08 { get; set; }
        public string Meal_Item_Roast_08_Caption { get; set; }
        public string Meal_Item_Roast_10 { get; set; }
        public string Meal_Item_Roast_10_Caption { get; set; }
        public string Meal_Item_Roast_11 { get; set; }
        public string Meal_Item_Roast_11_Caption { get; set; }
        public string Meal_Item_Roast_12 { get; set; }
        public string Meal_Item_Roast_12_Caption { get; set; }
        public string Meal_Item_Roast_13 { get; set; }
        public string Meal_Item_Roast_13_Caption { get; set; }
        public string Meal_Item_Roast_15 { get; set; }
        public string Meal_Item_Roast_15_Caption { get; set; }
        public string Meal_Item_Roast_16 { get; set; }
        public string Meal_Item_Roast_16_Caption { get; set; }
        public string Meal_Item_Roast_18 { get; set; }
        public string Meal_Item_Roast_18_Caption { get; set; }
        public string Meal_Item_Roast_19 { get; set; }
        public string Meal_Item_Roast_19_Caption { get; set; }
        public string Meal_Item_Roast_24 { get; set; }
        public string Meal_Item_Roast_24_Caption { get; set; }
        public string Meal_Item_Roast_27 { get; set; }
        public string Meal_Item_Roast_27_Caption { get; set; }
        public string Meal_Item_Roast_28 { get; set; }
        public string Meal_Item_Roast_28_Caption { get; set; }
        public string Meal_Item_Roast_31 { get; set; }
        public string Meal_Item_Roast_31_Caption { get; set; }
        public string Meal_Item_Roast_32 { get; set; }
        public string Meal_Item_Roast_32_Caption { get; set; }
        public string Meal_Item_Roast_33 { get; set; }
        public string Meal_Item_Roast_33_Caption { get; set; }
        public string Meal_Item_Roast_36 { get; set; }
        public string Meal_Item_Roast_36_Caption { get; set; }
        public string Meal_Item_Roast_37 { get; set; }
        public string Meal_Item_Roast_37_Caption { get; set; }
        public string Meal_Item_Roast_38 { get; set; }
        public string Meal_Item_Roast_38_Caption { get; set; }
        public string Meal_Item_Roast_39 { get; set; }
        public string Meal_Item_Roast_39_Caption { get; set; }
        public string Meal_Item_Roast_40 { get; set; }
        public string Meal_Item_Roast_40_Caption { get; set; }
        public string Meal_Item_Roast_41 { get; set; }
        public string Meal_Item_Roast_41_Caption { get; set; }
        public string Meal_Item_Roast_45 { get; set; }
        public string Meal_Item_Roast_45_Caption { get; set; }
        public string Meal_Item_Roast_46 { get; set; }
        public string Meal_Item_Roast_46_Caption { get; set; }
        public string Meal_Item_Roast_48 { get; set; }
        public string Meal_Item_Roast_48_Caption { get; set; }
        public string Meal_Item_Roast_49 { get; set; }
        public string Meal_Item_Roast_49_Caption { get; set; }
        public string Meal_Item_Roast_50 { get; set; }
        public string Meal_Item_Roast_50_Caption { get; set; }
        public string Meal_Item_Roast_51 { get; set; }
        public string Meal_Item_Roast_51_Caption { get; set; }
        public string Meal_Item_Roast_52 { get; set; }
        public string Meal_Item_Roast_52_Caption { get; set; }
        public string Meal_Item_Roast_53 { get; set; }
        public string Meal_Item_Roast_53_Caption { get; set; }
        public string Meal_Item_Roast_54 { get; set; }
        public string Meal_Item_Roast_54_Caption { get; set; }
        public string Meal_Item_Roast_55 { get; set; }
        public string Meal_Item_Roast_55_Caption { get; set; }
        public string Meal_Item_Roast_56 { get; set; }
        public string Meal_Item_Roast_56_Caption { get; set; }
        public string Meal_Item_Roast_58 { get; set; }
        public string Meal_Item_Roast_58_Caption { get; set; }
        public string Meal_Item_Roast_59 { get; set; }
        public string Meal_Item_Roast_59_Caption { get; set; }
        public string Effect_AllSpeed_Desc { get; set; }
        public string Effect_AllSpeed_Desc_02 { get; set; }
        public string Effect_AllSpeed_Desc_03 { get; set; }
        public string Effect_AllSpeed_MedicineDesc { get; set; }
        public string Effect_AllSpeed_MedicineDesc_02 { get; set; }
        public string Effect_AllSpeed_MedicineDesc_03 { get; set; }
        public string Effect_AllSpeed { get; set; }
        public string Effect_AllSpeed_Feminine { get; set; }
        public string Effect_AllSpeed_Masculine { get; set; }
        public string Effect_AllSpeed_Neuter { get; set; }
        public string Effect_AllSpeed_Plural { get; set; }
        public string Effect_AttackUpCold_Desc { get; set; }
        public string Effect_AttackUpCold_Desc_02 { get; set; }
        public string Effect_AttackUpCold { get; set; }
        public string Effect_AttackUpCold_Feminine { get; set; }
        public string Effect_AttackUpCold_Masculine { get; set; }
        public string Effect_AttackUpCold_Neuter { get; set; }
        public string Effect_AttackUpCold_Plural { get; set; }
        public string Effect_AttackUpHot_Desc { get; set; }
        public string Effect_AttackUpHot_Desc_02 { get; set; }
        public string Effect_AttackUpHot { get; set; }
        public string Effect_AttackUpHot_Feminine { get; set; }
        public string Effect_AttackUpHot_Masculine { get; set; }
        public string Effect_AttackUpHot_Neuter { get; set; }
        public string Effect_AttackUpHot_Plural { get; set; }
        public string Effect_AttackUpThunderstorm_Desc { get; set; }
        public string Effect_AttackUpThunderstorm_Desc_02 { get; set; }
        public string Effect_AttackUpThunderstorm { get; set; }
        public string Effect_AttackUpThunderstorm_Feminine { get; set; }
        public string Effect_AttackUpThunderstorm_Masculine { get; set; }
        public string Effect_AttackUpThunderstorm_Neuter { get; set; }
        public string Effect_AttackUpThunderstorm_Plural { get; set; }
        public string Effect_AttackUp_Desc { get; set; }
        public string Effect_AttackUp_Desc_02 { get; set; }
        public string Effect_AttackUp_Desc_03 { get; set; }
        public string Effect_AttackUp_MedicineDesc { get; set; }
        public string Effect_AttackUp_MedicineDesc_02 { get; set; }
        public string Effect_AttackUp_MedicineDesc_03 { get; set; }
        public string Effect_AttackUp { get; set; }
        public string Effect_AttackUp_Feminine { get; set; }
        public string Effect_AttackUp_Masculine { get; set; }
        public string Effect_AttackUp_Neuter { get; set; }
        public string Effect_AttackUp_Plural { get; set; }
        public string Effect_DefenseUp_Desc { get; set; }
        public string Effect_DefenseUp_Desc_02 { get; set; }
        public string Effect_DefenseUp_Desc_03 { get; set; }
        public string Effect_DefenseUp_MedicineDesc { get; set; }
        public string Effect_DefenseUp_MedicineDesc_02 { get; set; }
        public string Effect_DefenseUp_MedicineDesc_03 { get; set; }
        public string Effect_DefenseUp { get; set; }
        public string Effect_DefenseUp_Feminine { get; set; }
        public string Effect_DefenseUp_Masculine { get; set; }
        public string Effect_DefenseUp_Neuter { get; set; }
        public string Effect_DefenseUp_Plural { get; set; }
        public string Effect_ExStaminaMaxUp_Desc { get; set; }
        public string Effect_ExStaminaMaxUp_MedicineDesc { get; set; }
        public string Effect_ExStaminaMaxUp { get; set; }
        public string Effect_ExStaminaMaxUp_Feminine { get; set; }
        public string Effect_ExStaminaMaxUp_Masculine { get; set; }
        public string Effect_ExStaminaMaxUp_Neuter { get; set; }
        public string Effect_ExStaminaMaxUp_Plural { get; set; }
        public string Effect_LifeRepair_Desc { get; set; }
        public string Effect_LifeRepair { get; set; }
        public string Effect_LifeRepair_Feminine { get; set; }
        public string Effect_LifeRepair_Masculine { get; set; }
        public string Effect_LifeRepair_Neuter { get; set; }
        public string Effect_LifeRepair_Plural { get; set; }
        public string Effect_LifeMaxUp_Desc { get; set; }
        public string Effect_LifeMaxUp_MedicineDesc { get; set; }
        public string Effect_LifeMaxUp { get; set; }
        public string Effect_LifeMaxUp_Feminine { get; set; }
        public string Effect_LifeMaxUp_Masculine { get; set; }
        public string Effect_LifeMaxUp_Neuter { get; set; }
        public string Effect_LifeMaxUp_Plural { get; set; }
        public string Effect_LightEmission_Desc { get; set; }
        public string Effect_LightEmission_Desc_02 { get; set; }
        public string Effect_LightEmission_Desc_03 { get; set; }
        public string Effect_LightEmission_MedicineDesc { get; set; }
        public string Effect_LightEmission_MedicineDesc_02 { get; set; }
        public string Effect_LightEmission_MedicineDesc_03 { get; set; }
        public string Effect_LightEmission { get; set; }
        public string Effect_LightEmission_Feminine { get; set; }
        public string Effect_LightEmission_Masculine { get; set; }
        public string Effect_LightEmission_Neuter { get; set; }
        public string Effect_LightEmission_Plural { get; set; }
        public string Effect_MiasmaGuard_Desc { get; set; }
        public string Effect_MiasmaGuard_Desc_02 { get; set; }
        public string Effect_MiasmaGuard_Desc_03 { get; set; }
        public string Effect_MiasmaGuard { get; set; }
        public string Effect_MiasmaGuard_Feminine { get; set; }
        public string Effect_MiasmaGuard_Masculine { get; set; }
        public string Effect_MiasmaGuard_Neuter { get; set; }
        public string Effect_MiasmaGuard_Plural { get; set; }
        public string Effect_NotSlippy_MedicineDesc { get; set; }
        public string Effect_NotSlippy_MedicineDesc_02 { get; set; }
        public string Effect_NotSlippy_MedicineDesc_03 { get; set; }
        public string Effect_NotSlippy { get; set; }
        public string Effect_NotSlippy_Feminine { get; set; }
        public string Effect_NotSlippy_Masculine { get; set; }
        public string Effect_NotSlippy_Neuter { get; set; }
        public string Effect_NotSlippy_Plural { get; set; }
        public string Effect_QuietnessUp_Desc { get; set; }
        public string Effect_QuietnessUp_Desc_02 { get; set; }
        public string Effect_QuietnessUp_Desc_03 { get; set; }
        public string Effect_QuietnessUp_MedicineDesc { get; set; }
        public string Effect_QuietnessUp_MedicineDesc_02 { get; set; }
        public string Effect_QuietnessUp_MedicineDesc_03 { get; set; }
        public string Effect_QuietnessUp { get; set; }
        public string Effect_QuietnessUp_Feminine { get; set; }
        public string Effect_QuietnessUp_Masculine { get; set; }
        public string Effect_QuietnessUp_Neuter { get; set; }
        public string Effect_QuietnessUp_Plural { get; set; }
        public string Effect_ResistBurn_MedicineDesc { get; set; }
        public string Effect_ResistBurn_MedicineDesc_02 { get; set; }
        public string Effect_ResistBurn { get; set; }
        public string Effect_ResistBurn_Feminine { get; set; }
        public string Effect_ResistBurn_Masculine { get; set; }
        public string Effect_ResistBurn_Neuter { get; set; }
        public string Effect_ResistBurn_Plural { get; set; }
        public string Effect_ResistCold_Desc { get; set; }
        public string Effect_ResistCold_Desc_02 { get; set; }
        public string Effect_ResistCold_MedicineDesc { get; set; }
        public string Effect_ResistCold_MedicineDesc_02 { get; set; }
        public string Effect_ResistCold { get; set; }
        public string Effect_ResistCold_Feminine { get; set; }
        public string Effect_ResistCold_Masculine { get; set; }
        public string Effect_ResistCold_Neuter { get; set; }
        public string Effect_ResistCold_Plural { get; set; }
        public string Effect_ResistElectric_Desc { get; set; }
        public string Effect_ResistElectric_Desc_02 { get; set; }
        public string Effect_ResistElectric_Desc_03 { get; set; }
        public string Effect_ResistElectric_MedicineDesc { get; set; }
        public string Effect_ResistElectric_MedicineDesc_02 { get; set; }
        public string Effect_ResistElectric_MedicineDesc_03 { get; set; }
        public string Effect_ResistElectric { get; set; }
        public string Effect_ResistElectric_Feminine { get; set; }
        public string Effect_ResistElectric_Masculine { get; set; }
        public string Effect_ResistElectric_Neuter { get; set; }
        public string Effect_ResistElectric_Plural { get; set; }
        public string Effect_ResistHot_Desc { get; set; }
        public string Effect_ResistHot_Desc_02 { get; set; }
        public string Effect_ResistHot_MedicineDesc { get; set; }
        public string Effect_ResistHot_MedicineDesc_02 { get; set; }
        public string Effect_ResistHot { get; set; }
        public string Effect_ResistHot_Feminine { get; set; }
        public string Effect_ResistHot_Masculine { get; set; }
        public string Effect_ResistHot_Neuter { get; set; }
        public string Effect_ResistHot_Plural { get; set; }
        public string Effect_StaminaRecover_Desc { get; set; }
        public string Effect_StaminaRecover_MedicineDesc { get; set; }
        public string Effect_StaminaRecover { get; set; }
        public string Effect_StaminaRecover_Feminine { get; set; }
        public string Effect_StaminaRecover_Masculine { get; set; }
        public string Effect_StaminaRecover_Neuter { get; set; }
        public string Effect_StaminaRecover_Plural { get; set; }
        public string Effect_SwimSpeedUp_Desc { get; set; }
        public string Effect_SwimSpeedUp_Desc_02 { get; set; }
        public string Effect_SwimSpeedUp { get; set; }
        public string Effect_SwimSpeedUp_Feminine { get; set; }
        public string Effect_SwimSpeedUp_Masculine { get; set; }
        public string Effect_SwimSpeedUp_Neuter { get; set; }
        public string Effect_SwimSpeedUp_Plural { get; set; }
        public string Buff_AllSpeed { get; set; }
        public string Buff_AttackUp { get; set; }
        public string Buff_AttackUpBow { get; set; }
        public string Buff_AttackUpBowPlus { get; set; }
        public string Buff_AttackUpCold { get; set; }
        public string Buff_AttackUpHot { get; set; }
        public string Buff_AttackUpThunderstorm { get; set; }
        public string Buff_AttackUpWeapon { get; set; }
        public string Buff_AttackUpWeaponPlus { get; set; }
        public string Buff_ChargePowerUpCold { get; set; }
        public string Buff_ChargePowerUpHot { get; set; }
        public string Buff_ChargePowerUpThunderstorm { get; set; }
        public string Buff_ClimbSpeedUp { get; set; }
        public string Buff_DecreaseChargeAttackStamina { get; set; }
        public string Buff_DecreaseSwimStamina { get; set; }
        public string Buff_DecreaseWallJumpStamina { get; set; }
        public string Buff_DecreaseZonauEnergy { get; set; }
        public string Buff_DefenseUp { get; set; }
        public string Buff_DivingMobilityUp { get; set; }
        public string Buff_ExStaminaMaxUp { get; set; }
        public string Buff_FinishBlow { get; set; }
        public string Buff_GuardUp { get; set; }
        public string Buff_GuardUpPlus { get; set; }
        public string Buff_LifeMaxUp { get; set; }
        public string Buff_LifeRepair { get; set; }
        public string Buff_LightEmission { get; set; }
        public string Buff_LightFootprint { get; set; }
        public string Buff_LongThrow { get; set; }
        public string Buff_MiasmaDefenseUp { get; set; }
        public string Buff_MiasmaGuard { get; set; }
        public string Buff_NightMoveSpeedUp { get; set; }
        public string Buff_NoBurning { get; set; }
        public string Buff_NoFallDamage { get; set; }
        public string Buff_NoSlip { get; set; }
        public string Buff_NotSlippy { get; set; }
        public string Buff_QuietnessUp { get; set; }
        public string Buff_RapidShot { get; set; }
        public string Buff_ResistBurn { get; set; }
        public string Buff_ResistCold { get; set; }
        public string Buff_ResistElectric { get; set; }
        public string Buff_ResistFreeze { get; set; }
        public string Buff_ResistHot { get; set; }
        public string Buff_ResitLightning { get; set; }
        public string Buff_RupeeGuard { get; set; }
        public string Buff_SandMoveUp { get; set; }
        public string Buff_SetBonus_ResistElectric { get; set; }
        public string Buff_SnowMoveUp { get; set; }
        public string Buff_SpreadShot5 { get; set; }
        public string Buff_StalDisguise { get; set; }
        public string Buff_StaminaRecover { get; set; }
        public string Buff_SwimSpeedUp { get; set; }
        public string Buff_SwordBeamUp { get; set; }
        public string Buff_ToughnessUp { get; set; }
        public string Buff_ToughnessUpPlus { get; set; }
        public string Buff_ZonauEnergyHealUp { get; set; }
    }

    public class Recipedata
    {
        public string ResultActorName { get; set; }
        public string Recipe { get; set; }
        public int PictureBookNum { get; set; }
        public int BonusHeart { get; set; }
        public bool CookFailure { get; set; }
        public bool CookEMedicine { get; set; }
    }

    public class Singlerecipedata
    {
        public string Recipe { get; set; }
        public int PictureBookNum { get; set; }
        public int BonusHeart { get; set; }
        public bool IsSingleRecipe { get; set; }
        public bool CookFailure { get; set; }
    }
}