<template>
  <nav class="navbar navbar-expand-lg bg-light">
    <div class="container-fluid">
      <a class="navbar-brand">INBOX</a>
    </div>
  </nav>
  <div class="row">
    <div class="col-sm-6 mt-3">
      <div v-for="m in messages" :key="m.id">
        <div class="card mt-3" style="width: 18rem">
          <div class="card-body">
            <span class="card-title">{{ m.subject }}</span>
            <p class="card-text">{{ `${m.content.substr(0, 15)}...` }}</p>

            <a @click="read(m.id)" class="btn btn-primary">View Message</a>
            <input
              class="form-check-input m-1"
              type="checkbox"
              v-if="m.isRead"
              checked
              disabled
            />
          </div>
        </div>
      </div>
    </div>
  </div>
  <ReadMessage ref="readModal" @read="readMessage" />
</template>
<script>
import ReadMessage from "../views/ReadMessage.vue";
export default {
  name: "messages",
  data() {
    return {
      id: null,
      messages: [],
      selectedId: null,
    };
  },
  components: {
    ReadMessage,
  },
  mounted() {
    this.id = this.$route.params.id;
    this.$ajax
      .get(`api/message/list/${this.id}`)
      .then((response) => {
        if (response.data) {
          this.messages = response.data;
        }
      })
      .catch((error) => {});
  },
  methods: {
    read(id) {
      this.selectedId = id;
      this.$refs.readModal.open();
    },
    readMessage() {},
  },
};
</script>
<style>
span {
  font-size: x-large;
}
</style>
