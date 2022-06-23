<template>
  <div
    class="modal fade"
    id="exampleModal"
    tabindex="-1"
    aria-labelledby="exampleModalLabel"
    aria-hidden="true"
  >
    <div v-if="isFailed" class="alert alert-warning">
      Message could not be loaded
    </div>
    <div v-if="isSuccess" class="alert alert-success">
      Message read successfully
    </div>
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content">
        <div class="modal-header">
          <span class="modal-title" id="exampleModalLabel">{{
            this.subject
          }}</span>
          <button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></button>
        </div>
        <div class="modal-body">{{ this.content }}</div>
        <div class="modal-footer">
          <button
            type="button"
            class="btn btn-secondary"
            data-bs-dismiss="modal"
            v-on:click="readMessage(m.messageId)"
          >
            Close
          </button>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  emits: ["yes"],
  name: "ReadMessage",
  data() {
    return {
      instance: null,
      selectedId: null,
      subject: null,
      content: null,
      isFailed: false,
      isSuccess: false,
    };
  },
  mounted() {
    this.instance = new bootstrap.Modal(
      document.getElementById("exampleModal")
    );
  },
  methods: {
    open(id) {
      this.instance.show(id);
      this.selectedId = id;
      this.loadMessage(this.selectedId);
    },
    loadMessage(id) {
      this.$ajax
        .get(`api/message/get/${id}`)
        .then((response) => {
          if (response.data) {
            this.content = response.data.content;
            this.subject = response.data.subject;
            this.readMessage(this.selectedId);
          }
        })
        .catch((error) => {
          if (error) {
            this.isFailed = true;
          }
        });
    },
    readMessage(id) {
      this.$ajax
        .post(`api/message/read/${id}`)
        .then((response) => {
          if (response) {
            this.isSuccess = true;
            this.instance.hide();
            this.$emit("yes");
          }
        })
        .catch(() => {
          this.isFailed = true;
        });
    },
  },
};
</script>
<style></style>
