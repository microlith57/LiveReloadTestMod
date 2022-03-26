namespace Celeste.Mod.LiveReloadTestMod {
    public class LiveReloadTestModModule : EverestModule {

        public static LiveReloadTestModModule Instance;

        public LiveReloadTestModModule() {
            Instance = this;
        }

        public override void Load() {
            On.Celeste.Player.DashBegin += OnDashBegin;
        }

        public override void Unload() {
            On.Celeste.Player.DashBegin -= OnDashBegin;
        }

        private void OnDashBegin(On.Celeste.Player.orig_DashBegin orig, Player self) {
            orig(self);


            /* // from:
            self.ExplodeLaunch(self.Center - self.DashDir, snapUp: true);
            */ // to:
            self.ExplodeLaunch(self.Center - (self.DashDir * 100), snapUp: true);
        }

    }
}
