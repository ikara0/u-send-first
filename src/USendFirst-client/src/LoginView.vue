<template>
  <div v-if="isFailed" class="alert alert-warning">Login Failed</div>
  <div v-if="isSuccess" class="alert alert-success">Login Successful</div>

  <div class="tile">
    <div class="tile-header">
      <h2
        style="
          color: white;
          opacity: 0.75;
          font-size: 4rem;
          display: flex;
          justify-content: center;
          align-items: center;
          height: 100%;
        "
      >
        SIGN IN
      </h2>
    </div>

    <div class="tile-body">
      <div class="form-input">
        <span class="label"> <i class="material-icons">person</i> Email</span>
        <input
          type="email"
          autofocus="true"
          id="loginMail"
          v-model="email"
          class="form-control"
          required
        />
      </div>

      <div class="form-input">
        <span class="label"> <i class="material-icons">lock</i> Password</span>
        <input
          type="password"
          required
          id="password"
          v-model="password"
          class="form-control"
        />
      </div>
      <button class="btn btn-primary btn-block mb-3 w-100 mt-3" @click="login">
        Sign in
      </button>
    </div>
  </div>
</template>

<script>
export default {
  name: "login",
  data() {
    return {
      id: null,
      email: null,
      password: null,
      isFailed: false,
      isSuccess: false,
    };
  },
  methods: {
    login() {
      this.isFailed = false;
      this.isSuccess = false;
      let data = {
        eMail: this.email,
        Password: this.password,
      };
      this.$ajax
        .post("api/user/login", data)
        .then((response) => {
          if (response.data) {
            this.isSuccess = true;
            this.id = response.data.id;
            setTimeout(() => {
              this.$router.push({
                name: "welcome",
                params: { id: this.id },
              });
            }, 1000);
          }
        })
        .catch((error) => {
          this.isFailed = true;
        });
    },
  },
};
</script>

<style>
@import url("https://fonts.googleapis.com/css?family=Source+Sans+Pro:200,200i,300,300i,400,400i,600,600i,700,700i,900,900i|Monoton");
@import url("https://fonts.googleapis.com/icon?family=Material+Icons");

@import url("https://fonts.googleapis.com/css?family=Source+Sans+Pro:200,200i,300,300i,400,400i,600,600i,700,700i,900,900i|Monoton");
@import url("https://fonts.googleapis.com/icon?family=Material+Icons");

* {
  box-sizing: border-box;
}

html {
  font-size: 14px;
}

body {
  background: linear-gradient(to bottom, color("tranquil"), color("ice"));
  color: color("base");
  display: flex;
  align-items: center;
  justify-content: center;
  font-family: "Source Sans Pro", sans-serif;
  min-height: 100vh;
}
h1,
h2,
h3,
h4,
h5,
h6 {
  font-family: Monoton, sans-serif;
  margin-bottom: 0.5rem;
}

.tile {
  background-color: color("ice");
  border-radius: 0.1rem;
  box-shadow: 0 0.75rem 1.5rem rgba(0, 0, 0, 0.2),
    0 0.25rem 0.25rem rgba(0, 0, 0, 0.2);
  position: relative;
  width: 100%;
  min-width: 320px;
  max-width: 24rem;
  overflow: hidden;
}

.tile-header {
  background-image: url("https://res.cloudinary.com/dgmilxzy7/image/upload/c_scale,w_500,o_75,b_rgb:07beb8/v1506735375/CodePen/ViddenPixel.jpg");
  background-position: center;
  background-size: cover;
  height: 12rem;
}
.tile-body {
  padding: 2rem;
}

.form-input {
  display: block;
  position: relative;
}
.form-input.material-icons {
  position: absolute;
  font-size: 1.5rem;
  top: 1.2rem;
}
</style>
