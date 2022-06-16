<template>
  <div
    class="modal fade"
    id="exampleModal"
    tabindex="-1"
    aria-labelledby="exampleModalLabel"
    aria-hidden="true"
  >
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title" id="exampleModalLabel">Danger Zone!</h5>
          <button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></button>
        </div>
        <div class="modal-body">Silmek istediğinize emin misiniz ?</div>
        <div class="modal-footer">
          <button
            type="button"
            class="btn btn-secondary"
            data-bs-dismiss="modal"
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
  emits: ["read"],
  name: "ReadMessage",
  data() {
    return {
      instance: null,
      selectedId: null,
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
      console.log(this.selectedId);
    },
  },
};
</script>
<style></style>
