import Projects from "./project/Projects";
import Blogs from "./blog/Blog";
import { Home } from "./components/Home";
import UserProfileView from "./user/UserProfile";

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
    path: '/project',
    element: <Projects />
  }
];

export default AppRoutes;
