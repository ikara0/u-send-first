import { createRouter, createWebHistory } from "vue-router";

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: "/welcome/:id",
      name: "welcome",
      component: () => import("../views/WelcomeView.vue"),
    },
    {
      path: "/login",
      name: "login",
      component: () => import("../LoginView.vue"),
    },
    {
      path: "/messages/:id",
      name: "messages",
      component: () => import("../views/MessagesView.vue"),
    },
  ],
});

export default router;
