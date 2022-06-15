import axios from "axios";
export default {
  install: (app) => {
    const instance = axios.create({
      baseURL: "https://localhost:4000",
    });
    let ajax = {
      get: function (url) {
        return instance.get(url);
      },
      post: function (url, data) {
        return instance.post(url, data);
      },
    };
    app.config.globalProperties.$ajax = ajax;
  },
};
