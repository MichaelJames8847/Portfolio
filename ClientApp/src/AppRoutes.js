import Projects from "./project/Projects";
import Blogs from "./blog/Blog";
import { Home } from "./components/Home";
import UserProfileView from "./user/UserProfile";
import BlogDetail from "./blog/BlogDetail";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/about',
    element: <UserProfileView />
  },
  {
    path: '/blog',
    element: <Blogs />
  },
  {
    path: '/blog/:id',
    element: <BlogDetail />
  },
  {
    path: '/project',
    element: <Projects />
  }
];

export default AppRoutes;
